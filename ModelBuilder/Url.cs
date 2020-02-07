namespace ModelBuilder
{
    static class Url
    {
        static string Domain;
        public static string TransportUrl(ActionEnum action, string domain)
        {
            Domain = domain;
            if (action == ActionEnum.SELECT) { return SelectUrl; }
            else if (action == ActionEnum.UPDATE) { return UpdateUrl; }
            else if (action == ActionEnum.DELETE) { return DeleteUrl; }
            else if (action == ActionEnum.INSERT) { return InsertUrl; }
            else if (action == ActionEnum.SYSIMAGE) { return ImageUrl; }
            else if (action == ActionEnum.LOGOUT) { return LogoutUrl; }
            else if (action == ActionEnum.METADATA) { return MetaDataUrl; }
            return null;
        }
        private static string SelectUrl
        {
            get
            {
                return Domain + @"/0/dataservice/json/reply/SelectQuery";
            }
        }
        private static string UpdateUrl
        {
            get
            {
                return Domain + @"/0/dataservice/json/reply/UpdateQuery";
            }
        }
        private static string InsertUrl
        {
            get
            {
                return Domain + @"/0/dataservice/json/reply/InsertQuery";
            }
        }
        private static string DeleteUrl
        {
            get
            {
                return Domain + @"/0/dataservice/json/reply/DeleteQuery";
            }
        }
        private static string ImageUrl
        {
            get
            {
                return Domain + @"/0/img/entity/hash/SysImage/Data/";
            }
        }
        private static string LogoutUrl
        {
            get
            {
                return Domain + @"/0/rest/MainMenuService/Logout";
            }
        }
        private static string MetaDataUrl
        {
            get
            {
                return Domain + @"/0/ServiceModel/EntityDataService.svc/$metadata";
            }
        }
    }
}
