using DEMO_PROJET_07449.DataAccess.Contextes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.Business.Services;
public class MainService : IService {
    private ProjectContext _projectContext;
    private PatientService _patientService;
    private AppointmentService _appointmentService;

    private static MainService INSTANCE;

    private MainService() {
        ApplicationConfiguration.Initialize();
        this._projectContext = new ProjectContext();
        this._patientService = new PatientService(this._projectContext);
        this._appointmentService = new AppointmentService(this._projectContext);
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
        return this._patientService;
    }

    public AppointmentService GetAppointmentService() {
        return this._appointmentService;
    }
}
