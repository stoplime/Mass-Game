 /*Copyright (C) 2015 Timothy A. Oltjenbruns
  *
  *	This program is free software; you can redistribute it and/or modify
  *	it under the terms of the GNU General Public License as published by
  *	the Free Software Foundation; either version 2 of the License, or
  *	(at your option) any later version.
  *	
  *	This program is distributed in the hope that it will be useful,
  *	but WITHOUT ANY WARRANTY; without even the implied warranty of
  *	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  *	GNU General Public License for more details.
  *	
  *	You should have received a copy of the GNU General Public License along
  *	with this program; if not, write to the Free Software Foundation, Inc.,
  *	51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
  */
using System;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;

namespace TOltjenbruns.MassGame{
	public class E_Spray : Enemy
	{
		#region Private Fields
		
		#endregion
		
		#region Constructor
		public E_Spray (Player player, HashSet<Particle> particles, HashSet<Enemy> enemies)
			: this (player, particles, enemies, new Rgba(255, 0, 0, 255)){
		}
		
		public E_Spray (Player player, HashSet<Particle> particles, HashSet<Enemy> enemies,  Rgba colorMask)
			: base (player, particles, enemies, colorMask)
		{
			//TODO: initialize health
			
			//TODO: a lot ...
		}
		#endregion
		
		#region Original Methods
		
		
		#endregion
		
	}
}
