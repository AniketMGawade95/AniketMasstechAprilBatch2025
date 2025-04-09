using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_dbimplementation
{
     interface EmpRepo
    {
        void AddEmp();
        void showemplist();

        void updateemp();
        void deleteemplist();

        void readdata();
        void searchemp();
    }
}
