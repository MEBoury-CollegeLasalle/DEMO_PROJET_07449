using DEMO_PROJET_07449.DataAccess.Contextes;
using DEMO_PROJET_07449.DataAccess.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.Business.Services;
public class AppointmentService : IService {
    private AppointmentDAO appointmentDAO;

    public AppointmentService(ProjectContext context) { 
        this.appointmentDAO = new AppointmentDAO(context);
    }

}
