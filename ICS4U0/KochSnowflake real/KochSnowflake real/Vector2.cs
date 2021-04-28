using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KochSnowflake
{
    /******************************************************
     * The class "Vector2" models a two-dimensional vector
     ******************************************************/
    
    public class Vector2
    {
        
        /*****************************************************************
         * FIELDS of the 'Vector2' class
         * x, y: x and y components of this vector.
         * These fields are NOT exposed to the user of the class.
         * Their values are accessible through the properties 'X' and 'Y'
         ******************************************************************/
        private double x, y;


        /******************************
         * 
         * DECLARATION OF PROPERTIES
         * 
         *****************************/
        
        //The property 'X' represents the "x-component" of this vector.          
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        //The property 'Y' represents the "y-component" of this vector.
        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        //Set x and y components of this vector to 0
        public Vector2()
        {
            x = 0;
            y = 0;
        }

        //Set x and y components of this vector to x and y respectively
        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //Set this vector equal to the vector "v"
        public Vector2(Vector2 v)
        {
            x = v.x;
            y = v.y;
        }



        /*********************
         * INSTANCE METHODS
         ********************/
       
        //Copy the vector "v" to this vector
        public void copy(Vector2 v)
        {
            x = v.x;
            y = v.y;
        }

        //Return the sum of this vector and "v"
        public Vector2 add(Vector2 v)
        {
            return new Vector2(this.x + v.x, this.y + v.y);
        }

        //Return this vector subtract "v"
        public Vector2 subtract(Vector2 v)
        {
            return new Vector2(this.x - v.x, this.y - v.y);
        }


        //Return this vector multiplied by the scalar "a"
        public Vector2 timesScalar(double a)
        {
            return new Vector2(a * x, a * y);
        }

        //Return the dot product of this vector with the vector "v"	
        public double dotProduct(Vector2 v)
        {
            return x * v.x + y * v.y;
        }

        //Return the square of the magnitude of this vector
        public double squareOfMagnitude()
        {
            return x * x + y * y;
        }

        //Return the magnitude of this vector
        public double magnitude()
        {
            return Math.Sqrt(x * x + y * y);
        }

        //Normalize this vector
        public Vector2 normalize()
        {
            double normalizingFactor = 1 / Math.Sqrt(x * x + y * y);
            return new Vector2(x * normalizingFactor, y * normalizingFactor);
        }

        //Rotate this vector "theta" radians
        public Vector2 rotate(double theta)
        {
            double cosTheta, sinTheta;

            cosTheta = Math.Cos(theta);
            sinTheta = Math.Sin(theta);
                       
            return new Vector2(x * cosTheta - y * sinTheta, x * sinTheta + y * cosTheta);
           
        }

        //Rotate this vector "degrees" degrees
        public Vector2 rotateDeg(double degrees)
        {
            return rotate(Math.PI / 180.0d * degrees);
        }

        //Return a string representing this vector in the format (x, y)
        public string toStringOrderedPairNotation()
        {
            return "(" + this.X + ", " + this.Y + ")";
        }
        
        //Return a string representing this vector in the format xi + yj
        public string toStringUnitVectorNotation()
        {
            return this.X + "i " + ((this.Y < 0) ? "- " : "+ ") + Math.Abs(this.Y) + "j";
        }

        
            
        /**********************
         * STATIC METHODS
         *********************/

        //Return the sum of the vectors "v1" and "v2"
        public static Vector2 sum(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }

        //Return the difference of the vectors "v1" and "v2"
        public static Vector2 difference(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x - v2.x, v1.y - v2.y);
        }

        //Return the vector "v" multiplied by the scalar "a"
        public static Vector2 product(double a, Vector2 v)
        {
            return new Vector2(a * v.x, a * v.y);
        }

    }

}
