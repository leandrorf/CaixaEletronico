using System;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main( string[ ] args )
        {
            IniciarNota( );

            new CodigoFernando( ).Codigo( );
        }

        static void IniciarNota( )
        {
            int[ ] notas = new[ ] { 100, 10, 20, 200, 50 };
            int aux = 0;

            for ( int i = 0; i < notas.Count( ); i++ )
            {
                for ( int j = i + 1; j < notas.Count( ); j++ )
                {
                    if ( notas[ i ] < notas[ j ] )
                    {
                        aux = notas[ i ];
                        notas[ i ] = notas[ j ];
                        notas[ j ] = aux;
                    }
                }
            }
        }
    }
}
