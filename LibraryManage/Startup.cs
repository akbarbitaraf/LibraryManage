namespace LibraryManage
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
        {
            this.configuration = configuration;
        }
        public IConfiguration configuration { get; }
    }
}
