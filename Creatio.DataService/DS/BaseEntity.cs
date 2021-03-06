﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Creatio.DataService
{
    public class BaseEntity : INotifyPropertyChanged
    {
        #region Fields
        public bool HasChanges = false;
        public bool RecordFound = false;
        public List<string> ChangedColumns;
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        private Guid _Id;
        public virtual Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                OnPropertyChanged();
            }
        }
        public BaseEntity()
        {
            ChangedColumns = new List<string>();
        }


        /* Unused ExpandValues
        public void ExpandValues() {
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo prop in props) 
            {
                if (prop.Name == "Id") {
                    Guid.TryParse(prop.GetValue(this).ToString(), out Guid Id);
                    if (Id != Guid.Empty)
                        this.Id = Id;
                }
            }

            if (Id == Guid.Empty) return;

            MethodInfo select = typeof(Utils).GetMethod("Select");
            Type tThis = this.GetType();
            MethodInfo generic = select.MakeGenericMethod(tThis);
            object[] args = { Id.ToString() };

            object selectReturn = generic.Invoke(Utils.Instance, args);

            var taskResult = selectReturn?.GetType().GetProperty("Result")?.GetValue(selectReturn); //a is a Task.Result or List<Entity>

            if (taskResult == null)
                return;

            IList elements = (IList)taskResult;

            if(elements.Count == 0)
                return;

            var element = elements[0];

            List<PropertyInfo> propsList = element.GetType().GetProperties().ToList();
            foreach (PropertyInfo prop in props) 
            {
                int index = propsList.FindIndex(i => i.Name == prop.Name);

                if (index >= 0) 
                {
                    var value = propsList[index].GetValue(element);
                    prop.SetValue(this, value);
                }
            }

            
            this.HasChanges = false;
            this.ChangedColumns.Clear();

        }
        /*

        /* Unused ExpandAllNav
        public void ExpandAllNav(params string[] properties) {

            List<PropertyInfo> props = new List<PropertyInfo>();
            if (properties?.Length > 0)
            {
                foreach (string item in properties)
                {
                    PropertyInfo pInfo = this.GetType().GetProperty(item);
                    props.Add(pInfo);
                }
            }
            else 
            {
                PropertyInfo[] p = this.GetType().GetProperties();
                foreach (PropertyInfo property in this.GetType().GetProperties())
                {
                    if (property.GetCustomAttribute<CPropertyAttribute>().Navigation != null) 
                    {
                        props.Add(property);
                    }
                }
            }

            #if DEBUG
            Console.ForegroundColor = ConsoleColor.Green;
            string propsList = string.Join(", ", properties);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You've asked to expand the following Naviagtions of the {this.GetType().Name}: {propsList}");
            Console.WriteLine($"I will attempt to execute requests in parallel ... Total to Expand: {props.Count}");
            Console.WriteLine();
            Console.ResetColor();
            #endif            
            MethodInfo select = typeof(Utils).GetMethod("Select");
            Type tThis = this.GetType();
            
           



        Parallel.ForEach(props, (prop) => {

                //string typeName = tThis.GetProperty(prop.Name).PropertyType.FullName;
                Type entityType = tThis.GetProperty(prop.Name).PropertyType;
                //Type entityType = assembly.GetType(typeName);
                
                string[] navigationAttribute = tThis.GetProperty(prop.Name).GetCustomAttribute<CPropertyAttribute>().Navigation?.Split(':');

                string key = (navigationAttribute?.Length == 2) ? navigationAttribute[1] : string.Empty;
                if (string.IsNullOrEmpty(key))
                    return;

                string id = tThis.GetProperty(key).GetValue(this, null)?.ToString();
                if (id == Guid.Empty.ToString())
                    return;

                //I want to invoke Select method
                //Select<Entity>(string id = "")

                MethodInfo generic = select.MakeGenericMethod(entityType);
                object[] args = { id };

#if DEBUG
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\tExpanding {prop.Name} of Type {entityType} by Id: {id}");
                Stopwatch propStopWatch = new Stopwatch();

                propStopWatch.Start();
#endif

                //select return List<Entity>
                //Invoking Select Method on Utils.Instance with args as arguments
                object selectReturn = generic.Invoke(Utils.Instance, args);

                //Select method returns TASK.Resut,  thus "a" is a Task.Result or List<Entity>
                var taskResult = selectReturn.GetType().GetProperty("Result").GetValue(selectReturn); //a is a Task.Result or List<Entity>
#if DEBUG
                propStopWatch.Stop();
#endif

                IList elements = (IList)taskResult;
                if (elements.Count > 0)
                {
#if DEBUG
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\tSetting value for {prop.Name}, it took me: {propStopWatch.Elapsed.TotalSeconds} seconds.");
                    Console.ResetColor();
#endif
                    prop.SetValue(this, elements[0]);
                }
            });


#region hidden
//foreach (PropertyInfo prop in props)
//{
//    if (prop.GetCustomAttribute<CPropertyAttribute>()?.Navigation != null) {

//        var val = this.GetType().GetProperty(prop.Name).GetValue(this, null);
//        string id = val.GetType().GetProperty("Id").GetValue(val, null).ToString(); //assume id is the Key

//        //I want to invoke Select method
//        //Select<Entity>(string id = "")
//        MethodInfo select = typeof(Utils).GetMethod("Select");
//        MethodInfo generic = select.MakeGenericMethod(val.GetType());

//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine($"\tExpanding {val.GetType()} by Id: {id}");
//        Console.ResetColor();

//        object[] args = { id };

//        Stopwatch propStopWatch = new Stopwatch();
//        propStopWatch.Reset();
//        propStopWatch.Start();
//        //select return List<Entity>
//        object selectReturn = generic.Invoke(Utils.Instance, args);
//        var a = selectReturn.GetType().GetProperty("Result").GetValue(selectReturn);
//        propStopWatch.Stop();

//        IList elements = (IList)a;

//        if (elements.Count > 0) {

//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"\tSetting value for {prop.Name}, it took me: {propStopWatch.Elapsed.TotalSeconds} seconds.");
//            Console.ResetColor();
//            Console.WriteLine();
//            prop.SetValue(this, elements[0]);               
//        }
//    }
//}
#endregion

#if DEBUG
            stopwatch.Stop();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"I am done expanding properties of {this.GetType().Name}, it took me {stopwatch.Elapsed.TotalSeconds} seconds.");
            Console.ResetColor();
#endif

        }

        */

        /* Unused ExpandAllAssociations

        /// <summary>
        /// Expands association properties of the object
        /// </summary>
        /// <param name="properties">Optional parameters, if empty expands all properties</param>
        public void ExpandAllAssociations(params string[] properties) 
        {
            List<PropertyInfo> props = new List<PropertyInfo>();
            if (properties?.Length > 0)
            {
                foreach (string item in properties)
                {
                    PropertyInfo pInfo = this.GetType().GetProperty(item);
                    props.Add(pInfo);
                }
            }
            else
            {
                PropertyInfo[] p = this.GetType().GetProperties();
                foreach (PropertyInfo property in this.GetType().GetProperties())
                {
                    if (property.GetCustomAttribute<CPropertyAttribute>().Association != null)
                    {
                        props.Add(property);
                    }
                }
            }
#if DEBUG
            Console.ForegroundColor = ConsoleColor.Green;
            string propsList = string.Join(", ", properties);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You've asked to expand the following associations of the {this.GetType().Name}: {propsList}");
            Console.WriteLine("I will attempt to execute requests in parallel ...");
            Console.WriteLine();
            Console.ResetColor();
#endif
            //Assembly assembly = Assembly.GetCallingAssembly();
            MethodInfo select = typeof(Utils).GetMethod("SelectAssociation");
            Type tThis = this.GetType();
            
            Parallel.ForEach(props, (prop) =>
            {
                Type entityType;
                if (this.GetType().GetProperty(prop.Name).PropertyType.IsGenericType)
                {
                    entityType = this.GetType().GetProperty(prop.Name).PropertyType.GetGenericArguments().FirstOrDefault().UnderlyingSystemType;
                }
                else return;

                string id = tThis.GetProperty("Id").GetValue(this, null).ToString();
                if (id == Guid.Empty.ToString())
                    return;

                //prop.Name = ContactAddressByContact
                //attr=ContactAddress:ContactId
                string attr = tThis.GetProperty(prop.Name).GetCustomAttribute<CPropertyAttribute>()?.Association;
                if (attr.Contains("ERROR")) return;
                string parentColumnName = attr.Split(':')[1];
                parentColumnName = parentColumnName.Substring(0, parentColumnName.Length - 2);

                //I want to invoke Select method
                //Select<Entity>(string id = "")
                MethodInfo generic = select.MakeGenericMethod(entityType);

#if DEBUG
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\tExpanding {prop.Name} of Type {entityType} by Id: {id}");
#endif

                object[] args = { id, parentColumnName };

                Stopwatch propStopWatch = new Stopwatch();
                propStopWatch.Start();
                object selectReturn = generic.Invoke(Utils.Instance, args);

                var taskResult = selectReturn?.GetType().GetProperty("Result")?.GetValue(selectReturn); //a is a Task.Result or List<Entity>
                propStopWatch.Stop();
                IList elements = (IList)taskResult;

                if (elements.Count > 0)
                {
#if DEBUG
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\tSetting value for {prop.Name}, it took me: {propStopWatch.Elapsed.TotalSeconds} seconds.");
                    Console.ResetColor();
#endif
                    prop.SetValue(this, elements);
                }
            });


#if DEBUG
            stopwatch.Stop();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"I am done expanding properties of {this.GetType().Name}, it took me {stopwatch.Elapsed.TotalSeconds} seconds.");
            Console.ResetColor();
#endif
        }
        */

        /* Unused Delete
        public RequestResponse DeleteEntity()
        {
            PropertyInfo[] props = this.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                if (prop.Name == "Id")
                {
                    Guid.TryParse(prop.GetValue(this).ToString(), out Guid Id);
                    if (Id != Guid.Empty)
                        this.Id = Id;
                }
            }

            MethodInfo select = typeof(Utils).GetMethod("DeleteAsyc");
            Type tThis = this.GetType();
            MethodInfo generic = select.MakeGenericMethod(tThis);
            object[] args = { Id.ToString() };

            object deleteReturn = generic.Invoke(Utils.Instance, args);

            var taskResult = deleteReturn?.GetType().GetProperty("Result")?.GetValue(deleteReturn); 

            
            RequestResponse response = (RequestResponse)taskResult;
            return response;
        }
        */

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

            if (!ChangedColumns.Contains(name))
            {
                ChangedColumns.Add(name);
                HasChanges = true;
            }
        }
    }
}
