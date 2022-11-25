using DEMO_PROJET_07449.DataAccess.Contextes;
using DEMO_PROJET_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.DataAccess.Daos;
public class PatientDAO : IDAO<PatientDTO> {
    private ProjectContext _projectContext;

    public PatientDAO(ProjectContext projectContext) { 
        this._projectContext = projectContext;
    }

    public PatientDTO GetById(int id) {
        return this._projectContext.Patients.Where(patient => patient.Id == id).Single();
    }

    public List<PatientDTO> GetAll() {
        return this._projectContext.Patients.ToList();
    }

    public PatientDTO Create(PatientDTO newPatient) {
        this._projectContext.Patients.Add(newPatient);
        this._projectContext.SaveChanges();
        return newPatient;
    }

    public PatientDTO Update(PatientDTO patient) {
        this._projectContext.Patients.Update(patient);
        this._projectContext.SaveChanges();
        return patient;
    }

    public PatientDTO Delete(PatientDTO patient) {
        this._projectContext.Patients.Remove(patient);
        this._projectContext.SaveChanges();
        return patient;
    }
}
