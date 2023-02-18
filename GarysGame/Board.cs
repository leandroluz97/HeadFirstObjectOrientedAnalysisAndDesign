using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarysGame
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Tile[,] Tiles { get; set; }
        public Board(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new Tile[Width, Height];
            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < Tiles.GetLength(0); i++)
            {
                for (int j = 0; j < Tiles.GetLength(1); i++)
                {
                    Tiles[i, j] = new Tile();
                }
            }
           
        }

        public Tile? GetTile(int x, int y)
        {
            Tile tile = Tiles[x, y];
            if (tile != null) return tile;
            return null;
        }

        public void AddUnit(Unit unit, int x, int y)
        {
            Tile? tile = GetTile(x,y);
            if(tile != null)
            {
                tile.AddUnit(unit); 
            }
       }

        public void RemoveUnit(Unit unit, int x, int y)
        {
            Tile? tile = GetTile(x, y);
            if (tile != null)
            {
                tile.RemoveUnit(unit);
            }
        }

        public void RemoveUnits(Unit unit, int x, int y)
        {
            Tile? tile = GetTile(x, y);
            if (tile != null)
            {
                tile.RemoveUnits();
            }
        }

        public List<Unit>? GetUnits(int x, int y)
        {
            Tile? tile = GetTile(x, y);
            if( tile != null)
            {
                return tile.GetUnits();
            }
            return null;
        }

        public void RemoveTile(int x, int y)
        {
            Tile? tile = GetTile(x, y);
            Tile[,] _tiles = new Tile[Tiles.GetLength(0)-1, Tiles.GetLength(1)-1];
            int _aux = 0;
            int _aux1 = 0;
            if ( tile != null)
            {
                for (int i = 0; i < _tiles.GetLength(0); i++)
                {
                    for (int j = 0; j < _tiles.GetLength(1); j++)
                    {
                        if (i == x && j == y)
                        {
                            ++_aux;
                            ++_aux1;
                            _tiles[i, j] = Tiles[i + _aux, j + _aux1];
                            continue;
                        }
                        _tiles[i, j] = Tiles[i + _aux, j + _aux1];
                    }

                }
            }
        }
    }
}
