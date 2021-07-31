using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Caixa
{
    public class NotasIndo
    {
        public int Quantidade { get; set; }
        public int Valor { get; set; }
    }

    public class NotasDisponiveis
    {
        public void IniciarNota( )
        {
            List<NotasIndo> notas = new List<NotasIndo>( )
            {
                new NotasIndo( )
                {
                    Quantidade = 10,
                    Valor = 100
                },
                new NotasIndo( )
                {
                    Quantidade = 10,
                    Valor = 10
                },
                new NotasIndo( )
                {
                    Quantidade = 10,
                    Valor = 20
                },
                new NotasIndo( )
                {
                    Quantidade = 10,
                    Valor = 200
                },
                new NotasIndo( )
                {
                    Quantidade = 10,
                    Valor = 50
                }
            };

            notas = notas.OrderByDescending( x => x.Valor ).ToList( );

            //100, 10, 20, 200, 50 };
            //int aux = 0;

            //for ( int i = 0; i < notas.Count( ); i++ )
            //{
            //    for ( int j = i + 1; j < notas.Count( ); j++ )
            //    {
            //        if ( notas[ i ] < notas[ j ] )
            //        {
            //            aux = notas[ i ];
            //            notas[ i ] = notas[ j ];
            //            notas[ j ] = aux;
            //        }
            //    }
            //}
        }
    }
}
