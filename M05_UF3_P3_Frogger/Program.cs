using System;
using System.Collections.Generic;
using System.Linq;

namespace M05_UF3_P3_Frogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos los objetos que representan el mapa y le damos sus propiedades 
            Lane[] lane = new Lane[]
            {
            new Lane(0,false,ConsoleColor.DarkGreen,false,false,0, ' ', Utils.colorsLogs.ToList()),
            new Lane(1,true,ConsoleColor.DarkBlue,false,true,0.1f,Utils.charLogs,Utils.colorsLogs.ToList()),
            new Lane(2,true,ConsoleColor.DarkBlue,false,true,0.1f,Utils.charLogs,Utils.colorsLogs.ToList()),
            new Lane(3,true,ConsoleColor.DarkBlue,false,true,0.1f,Utils.charLogs,Utils.colorsLogs.ToList()),
            new Lane(4,true,ConsoleColor.DarkBlue,false,true,0.1f,Utils.charLogs,Utils.colorsLogs.ToList()),
            new Lane(5,true,ConsoleColor.DarkBlue,false,false,0.1f,Utils.charLogs,Utils.colorsLogs.ToList()),
            new Lane(6,false,ConsoleColor.DarkGreen,false,false,0, ' ',Utils.colorsLogs.ToList()),
            new Lane(7,false,ConsoleColor.DarkGray,true,false,0.1f,Utils.charCars,Utils.colorsCars.ToList()),
            new Lane(8,false,ConsoleColor.DarkGray,true,false,0.1f,Utils.charCars,Utils.colorsCars.ToList()),
            new Lane(9,false,ConsoleColor.DarkGray,true,false,0.1f,Utils.charCars,Utils.colorsCars.ToList()),
            new Lane(10,false,ConsoleColor.DarkGray,true,false,0.1f,Utils.charCars,Utils.colorsCars.ToList()),
            new Lane(11,false,ConsoleColor.DarkGray,true,false,0.1f,Utils.charCars,Utils.colorsCars.ToList()),
            new Lane(12,true,ConsoleColor.DarkGreen,false,false,0,' ',Utils.colorsLogs.ToList()),
            };
            //Creamos el objeto 'Jugador'
            Player jugador = new Player();
            //Declaramos el estado del juego en ejecución y se lo damos como condición al bucle
            Utils.GAME_STATE state = Utils.GAME_STATE.RUNNING;
            //Pintamos el mapa y actualizamos la posición del jugador
            while (state == Utils.GAME_STATE.RUNNING)
            {
                Vector2Int input = Utils.Input();

                for (int i = 0; i < lane.ToList().Count; i++)
                {
                    lane[i].Update();
                }
                state = jugador.Update(input, lane.ToList());
                for (int i = 0; i < lane.ToList().Count; i++)
                {
                    lane[i].Draw();
                }
                jugador.Draw();
                TimeManager.NextFrame();
            }
        }
    }
}
        