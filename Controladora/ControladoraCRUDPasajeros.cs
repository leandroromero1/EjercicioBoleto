namespace Controladora
{
    public class ControladoraCRUDPasajeros
    {
        private Modelo.BoleteriaContext context;
        
        public ControladoraCRUDPasajeros()
        {
            context = new Modelo.BoleteriaContext();
        }

        public void Agregar(Modelo.Pasajero pasajero)
        {
            
            context.Add(pasajero);
            context.SaveChanges();
        }
        public void Modificar(Modelo.Pasajero pasajero)
        {
            context.Update(pasajero);
            context.SaveChanges();

        }
        public void Eliminar(Modelo.Pasajero pasajero)
        {
            context.Remove(pasajero);
            context.SaveChanges();
        }

        public List<Modelo.Pasajero> RecuperarPasajeros()
        {
            return context.Pasajeros.ToList();
        }

        public List<Modelo.PasajeroEstudiante> RecuperarPasajerosEstudiantes()
        {
            return context.Pasajeros.Cast<Modelo.PasajeroEstudiante>().ToList();
        }
    }
}
