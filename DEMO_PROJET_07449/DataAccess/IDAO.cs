using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.DataAccess;
public interface IDAO<TDTO> where TDTO : IDTO {

    public TDTO GetById(int id);

    public List<TDTO> GetAll();

}
