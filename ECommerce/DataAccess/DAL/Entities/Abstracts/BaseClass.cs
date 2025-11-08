using DAL.Entities.Enums;
using DAL.Utils;

namespace DAL.Entities.Abstracts
{
    public abstract class BaseClass : IEntity<Guid>
    {
        protected BaseClass()
        {
            MasterId = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            Status = DataStatus.Active;
            ComputerName = System.Environment.MachineName;

            IpAddress = IpAddressFinder.GetHostName();

        }
        public int ID { get ; set ; }
        public Guid MasterId { get ; set ; }//constructor tarafında doldurulur 
        public DateTime CreatedDate { get ; set ; } //constructor tarafında doldurulur
        public DateTime? ModifiedDate { get ; set ; }
        public string ComputerName { get ; set ; }  //constructor tarafında doldurulur+
        public string? ModifiedComputerName { get ; set ; }
        public string IpAddress { get ; set ; } //constructor tarafında doldurulur+
        public DataStatus Status { get ; set ; } //constructor tarafında doldurulur
    }
}
