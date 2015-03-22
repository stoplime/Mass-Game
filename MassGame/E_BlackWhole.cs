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
	public class E_BlackWhole : Enemy
	{
		#region Private Fields
		private Emitter avoidEmitter;
		#endregion
		
		#region Constructor
		public E_BlackWhole ()
			: this (new Rgba(0, 0, 0, 255)){
		}
		
		public E_BlackWhole (Rgba colorMask)
			: base (colorMask)
		{
			//TODO: initialize health
			
			avoidEmitter = new Emitter(100,0.3f,0,EmitterType.FORCE);
		}
		#endregion
		
		#region Original Methods
		public override void preUpdate (float delta)
		{
			base.preUpdate (delta);
			//Vector3 diff = Game.Player.Position.LoopDiff(Position);
			//attract(Game.Player.Position,targetEmitter,300,delta);
			foreach(Particle p in Game.Particles){
				if(!(p is E_BlackWhole)){
					attract(p.Position,avoidEmitter,300,delta);
				}
				else if(p!=this){
					attract(p.Position,avoidEmitter,300,delta);
				}
			}
		}
		
		#endregion
		
	}
}
