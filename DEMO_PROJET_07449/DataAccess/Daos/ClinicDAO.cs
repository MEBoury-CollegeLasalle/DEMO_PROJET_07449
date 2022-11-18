using DEMO_PROJET_07449.DataAccess.Contextes;
using DEMO_PROJET_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.DataAccess.Daos;
public class ClinicDAO : IDAO<ClinicDTO> {
    private ProjectContext context;

    public ClinicDAO(ProjectContext? context = null) {
        if (context is null) {
            context = new ProjectContext();
        }
        this.context = context;
    }


    public List<ClinicDTO> GetAll() {
        return this.context.Clinics.ToList();
    }

    public ClinicDTO GetById(int id) {
        return this.context.Clinics.Where(clinic => clinic.Id == id).Single();
    }
}
