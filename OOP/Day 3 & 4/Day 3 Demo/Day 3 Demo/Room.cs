using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Demo
{
    internal class Room
    {
		private Wall[] _walls;

		private Window[] _windows;

		public Window[] Windows
		{
			get { return _windows; }
			set { _windows = value; }
		}


		public Wall[] Walls
		{
			get { return _walls; }
			set
			{
                if (value != null)
                {
                    _walls = value;
                }
                else
                {
                    for (int i = 0; i < _walls.Length; i++)
                    {
                        _walls[i] = new Wall();
                    }
                }
            }
		}


		public Room(Wall[] walls, Window[] windows)
		{
			//Aggeregation
			_windows = windows;

			if(walls !=null)
			{
				_walls = walls;
			}
			else
			{
				for(int i=0; i < _walls.Length; i++)
				{
					//Composition
					_walls[i] = new Wall();
				}
			}
		}

	}
}


