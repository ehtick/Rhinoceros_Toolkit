/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2022, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using Rhino;

namespace BH.Engine.Rhinoceros
{
    public static partial class Query
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        public static double DocumentTolerance()
        {
            RhinoDoc doc = Rhino.RhinoDoc.ActiveDoc;

            if (doc != null)
                return doc.ModelAbsoluteTolerance;
            else
            {
                BH.Engine.Base.Compute.RecordWarning("Rhino document tolerance could not be retrieved because active document has not been found - standard BHoM geometrical tolerance is returned instead.");
                return BH.oM.Geometry.Tolerance.Distance;
            }
        }

        /***************************************************/
    }
}



