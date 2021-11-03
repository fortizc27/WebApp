using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Entity;

namespace WBL
{
    public interface ITIService
    {
        Task<DBEntity> Create(TIEntity entity);
        Task<DBEntity> Delete(TIEntity entity);
        Task<IEnumerable<TIEntity>> Get();
        Task<TIEntity> GetById(TIEntity entity);
        Task<DBEntity> Update(TIEntity entity);
    }

    public class TIService : ITIService
    {
        private readonly IDataAccess sql;

        public TIService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud

        //Get
        public async Task<IEnumerable<TIEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<TIEntity>("exp.TI_Obtener");

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //GetById
        public async Task<TIEntity> GetById(TIEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<TIEntity>("exp.TI_Obtener", new { entity.IdTipoIdentificacion });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Create
        public async Task<DBEntity> Create(TIEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("exp.TI_Insertar", new
                {
                    entity.Descripcion
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Update
        public async Task<DBEntity> Update(TIEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("exp.TI_Actualizar", new
                {
                    entity.IdTipoIdentificacion,
                    entity.Descripcion
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Delete
        public async Task<DBEntity> Delete(TIEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("exp.TI_Eliminar", new
                {
                    entity.IdTipoIdentificacion
                });

                return await result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
