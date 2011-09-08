/*
   Copyright 2011 repetier repetierdev@googlemail.com

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Windows;
using OpenTK;

namespace RepetierHost.model
{
    public class Coord3D {
        public float x=0,y=0,z=0;
        public Coord3D() { }
        public Coord3D(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }
    public abstract class ThreeDModel
    {
        private bool selected = false;
        private Coord3D position = new Coord3D();
        private Coord3D rotation = new Coord3D();
        private Coord3D scale = new Coord3D(1,1,1);

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
        public Coord3D Position
        {
            get { return position; }
            set { position = value; }
        }
        public Coord3D Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }
        public Coord3D Scale
        {
            get { return scale; }
            set { scale = value; }
        }
        /// <summary>
        /// Has the model changed since last paint?
        /// </summary>
        public virtual bool Changed
        {
            get { return false; }
        }
        public virtual void Clear() {}
        abstract public void Paint();
    }
}
