using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_Cnhacungcap
    {

        private string _MSNCC;
        private string _TENNCC;
        private string _HANG;
      

        public string MSNCC { get => _MSNCC; set => _MSNCC = value; }
        public string TENNCC { get => _TENNCC; set => _TENNCC = value; }
        public string HANG { get => _HANG; set => _HANG = value; }
     
        public DTO_Cnhacungcap() { }

        public DTO_Cnhacungcap(string MSNCC, string TENNCC, string HANG)
        {
            this.MSNCC = MSNCC;
            this.TENNCC = TENNCC;
            this.HANG = HANG;
        }
        public DTO_Cnhacungcap(string MSNCC)
        {
            this.MSNCC = MSNCC;
        }
    }
}
