using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.repositories
{
    public interface Repository<T>
    {
        T save(T model);
        void delete(long id);
        List<T> findAll();
        T findById(long id);
    }
}