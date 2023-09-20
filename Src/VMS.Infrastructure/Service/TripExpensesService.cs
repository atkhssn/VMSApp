using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Infrastructure.Model;
using VMS.Persistence;

namespace VMS.Infrastructure.Service
{
    public  class TripExpensesService
    {

        public IUnitOfWork _unitOfWork { get; set; }
        public TripExpensesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


       public bool create(TripExpensesModel model)
        {


            return false;
        }
    }
}
