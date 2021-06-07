using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemasUmg
{
    public class Jugador
    {
        public int IdJugador { get; set; }
        public int FechaNacimiento { get; set; }
        public int Camiseta { get; set; }
        public int IdEquipo { get; set; }
        public int IdPosicion { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public void InsertarJugador()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerJugador()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerJugadores()
        {
            throw new System.NotImplementedException();
        }
        public void ActualizarJugador()
        {
            throw new System.NotImplementedException();
        }
        public void BorrarJugador()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Partido
    {
        public int IdPartido { get; set; }
        public int IdEquipoA { get; set; }
        public int IdEquipoB { get; set; }
        public int PuntosEquipoA { get; set; }
        public int PuntosEquipoB { get; set; }
        public int FaltasEquipoA { get; set; }
        public int FaltasEquipob { get; set; }
        public int FechaDisputa { get; set; }
        public int IdArbitro { get; set; }
        public void InsertarPartido()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerPartido()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerPartidos()
        {
            throw new System.NotImplementedException();
        }
        public void ActualizarPartido()
        {
            throw new System.NotImplementedException();
        }
        public void BorrarPartido()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Equipo
    {
        public int IdEquipo { get; set; }
        public int Nombre { get; set; }
        public int Ubicacion { get; set; }
        public int IdTecnico { get; set; }
        public int IdLiga { get; set; }

        public Partido Partido
        {
            get => default;
            set
            {
            }
        }

        public Partido Partido1
        {
            get => default;
            set
            {
            }
        }

        public Jugador Jugador
        {
            get => default;
            set
            {
            }
        }

        public Tecnico Tecnico
        {
            get => default;
            set
            {
            }
        }

        public void InsertarEquipo()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerEquipo()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerEquipos()
        {
            throw new System.NotImplementedException();
        }
        public void ActualizarLiga()
        {
            throw new System.NotImplementedException();
        }
        public void BorrarLiga()
        {
            throw new System.NotImplementedException();
        }

    }

    public class Liga
    {
        public int IdLiga { get; set; }
        public int Nombre { get; set; }

        public Equipo Equipo
        {
            get => default;
            set
            {
            }
        }

        public void InsertarLiga()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerLiga()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerLigas()
        {
            throw new System.NotImplementedException();
        }
        public void ActualizarLiga()
        {
            throw new System.NotImplementedException();
        }
        public void BorrarLiga()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Posicion
    {
        public int IdPosicion { get; set; }
        public int Nombre { get; set; }

        public Jugador Jugador
        {
            get => default;
            set
            {
            }
        }

        public void InsertarPosicion()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerPosicion()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerPosiciones()
        {
            throw new System.NotImplementedException();
        }
        public void ActualizarPosicion()
        {
            throw new System.NotImplementedException();
        }
        public void BorrarPosicion()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Arbitro
    {
        public int IdArbitro { get; set; }
        public int FechaNacimiento { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public Partido Partido
        {
            get => default;
            set
            {
            }
        }

        public void InsertarArbitro()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerArbitro()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerArbitros()
        {
            throw new System.NotImplementedException();
        }
        public void ActualizarArbitro()
        {
            throw new System.NotImplementedException();
        }
        public void BorrarArbitro()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Tecnico
    {
        public int IdTecnico { get; set; }
        public int Nombre { get; set; }
        public int FechaNacimiento { get; set; }
        public int IdEquipo { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public Equipo Equipo
        {
            get => default;
            set
            {
            }
        }

        public void InsertarTecnico()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerTecnico()
        {
            throw new System.NotImplementedException();
        }
        public void ObtenerTecnicos()
        {
            throw new System.NotImplementedException();
        }
        public void ActualizarTecnico()
        {
            throw new System.NotImplementedException();
        }
        public void BorrarTecnico()
        {
            throw new System.NotImplementedException();
        }
    }
}