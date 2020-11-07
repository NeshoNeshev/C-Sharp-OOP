
namespace BorderControl
{
    public class Robot : IIdentifable
    {
        public Robot(string name,string id)
        {
            this.Model = name;
            this.Id = id;
            
        }
       
        public string Model { get ;private set; }
        public string Id { get;private set; }
    }
}
