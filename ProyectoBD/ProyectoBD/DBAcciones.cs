namespace ProyectoBD
{
    public class DBAcciones
    {
        private DBConexion db;

        public DBAcciones(DBConexion conexion)
        {
            db = conexion;
        }

        // INSERT (sin ID porque es IDENTITY)
        public int InsertarProyecto(string nombre)
        {
            string sql = $"INSERT INTO PROYECTO (Nombre) VALUES ('{nombre}')";
            return db.EjecutarComando(sql);
        }

        public int ActualizarProyecto(int id, string nuevoNombre)
        {
            string sql = $"UPDATE PROYECTO SET Nombre='{nuevoNombre}' WHERE IdProyecto={id}";
            return db.EjecutarComando(sql);
        }

        public int EliminarProyecto(int id)
        {
            string sql = $"DELETE FROM PROYECTO WHERE IdProyecto={id}";
            return db.EjecutarComando(sql);
        }
    }
}
