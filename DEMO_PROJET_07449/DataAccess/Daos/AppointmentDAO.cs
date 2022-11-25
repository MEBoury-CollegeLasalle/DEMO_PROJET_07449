using DEMO_PROJET_07449.DataAccess.Contextes;
using DEMO_PROJET_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.DataAccess.Daos;
public class AppointmentDAO : IDAO<AppointmentDTO> {
    private ProjectContext _projectContext;

    public AppointmentDAO(ProjectContext projectContext) {
        this._projectContext = projectContext;
    }


    public AppointmentDTO GetById(int id) {
        return this._projectContext.Appointments.Where(appointment => appointment.Id == id).Single();
    }

    public List<AppointmentDTO> GetAll() {
        return this._projectContext.Appointments.ToList();
    }

    public AppointmentDTO Create(AppointmentDTO newAppointment) {
        this._projectContext.Appointments.Add(newAppointment);
        this._projectContext.SaveChanges();
        return newAppointment;
    }

    public AppointmentDTO Update(AppointmentDTO appointment) {
        this._projectContext.Appointments.Update(appointment);
        this._projectContext.SaveChanges();
        return appointment;
    }

    public AppointmentDTO Delete(AppointmentDTO appointment) {
        this._projectContext.Appointments.Remove(appointment);
        this._projectContext.SaveChanges();
        return appointment;
    }
}
