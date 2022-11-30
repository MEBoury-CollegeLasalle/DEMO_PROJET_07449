using DEMO_PROJET_07449.DataAccess.Contextes;
using DEMO_PROJET_07449.DataAccess.Daos;
using DEMO_PROJET_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.Business.Services;
public class PatientService : IService {
    private PatientDAO patientDAO;

    public PatientService(ProjectContext appContext) {
        this.patientDAO = new PatientDAO(appContext);
    }

    public PatientDTO CreateNewPatient(string firstName, string lastName, string healthCardNumber) {
        PatientDTO patient = new PatientDTO(firstName, lastName, healthCardNumber);
        return this.patientDAO.Create(patient);
    }

    public PatientDTO CreateNewPatient(PatientDTO newPatient) {
        return this.patientDAO.Create(newPatient);
    }

    public PatientDTO SaveModifiedPatient(PatientDTO patient) {
        return this.patientDAO.Update(patient);
    }

    public PatientDTO DeletePatient(PatientDTO patient) {
        return this.patientDAO.Delete(patient);
    }

}
