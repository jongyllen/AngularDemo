using Nancy;

namespace AngularDemo.Nancy
{
    public class DefaultModule : NancyModule
    {
        public DefaultModule()
        {
            Get["/"] = request => View["demo"];
            Get["/todo"] = request => View["todo"];
            Get["/people"] = request => View["people"];
            Get["/controller"] = request => View["controller"];
            Get["/spa"] = request => View["spa"];
            Get["/demo"] = request => View["demo"];
        }
    }
}