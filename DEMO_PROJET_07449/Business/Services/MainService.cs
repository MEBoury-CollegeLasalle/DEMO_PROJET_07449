using DEMO_PROJET_07449.DataAccess.Contextes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.Business.Services;
public class MainService : IService {
    private ProjectContext projectContext;
    private PatientService patientService;
    private AppointmentService appointmentService;

    private static MainService INSTANCE;

    private MainService() {
        ApplicationConfiguration.Initialize();
        this.projectContext = new ProjectContext();
        this.patientService = new PatientService(this.projectContext);
        this.appointmentService = new AppointmentService(this.projectContext);
    }

    public static MainService GetInstance() {
        if (INSTANCE is null) {
            INSTANCE = new MainService();
        }
        return INSTANCE;
    }


    public void StartApplication() {
        Application.Run(new Form1());
    }

    public void ExitApplication() {
        Application.Exit();
    }

    public PatientService GetPatientService() {
        return this.patientService;
    }

    public AppointmentService GetAppointmentService() {
        return this.appointmentService;
    }
}
