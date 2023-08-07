using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MamiQueTuQuiere
{
    class Class_Matriz_Principal
    {
        Random rnd = new Random();





        public void Rellenar_Matriz(decimal variable, DataGridView tabla, Label vista)
        {
            int aux;
            aux = Convert.ToInt32(variable);
            // aux = 5;
            int filas, columnas;
            filas = aux + 1;
            columnas = aux + 1;
            int[,] MatrizPrincipal = new int[filas, columnas];

            //PRUEBA
            char[,] MatrizFuera = new char[filas, columnas];


            for (int i = 0; i < filas; i++)
            {

                for (int j = 0; j < columnas; j++)
                {

                    MatrizPrincipal[0, j] = j;
                    MatrizPrincipal[j, 0] = j;

                    if (MatrizPrincipal[i, j] == MatrizPrincipal[j, i])
                    {
                        MatrizPrincipal[i, j] = rnd.Next(10, 25);
                    }
                    else
                    {
                        MatrizPrincipal[i, j] = MatrizPrincipal[j, i];

                    }
                    if (!(MatrizPrincipal[j, j] == 0))
                    {
                        MatrizPrincipal[j, j] = 0;
                    }
                }
            }
            


            tabla.ColumnCount = columnas;
            tabla.RowCount = filas;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {


                    tabla.Rows[0].Cells[1].Value = 'A';
                    tabla.Rows[1].Cells[0].Value = 'A';

                    tabla.Rows[0].Cells[2].Value =  'B';
                    tabla.Rows[2].Cells[0].Value = 'B';

                    tabla.Rows[0].Cells[3].Value = 'C';
                    tabla.Rows[3].Cells[0].Value = 'C';

                    tabla.Rows[0].Cells[4].Value = 'D';
                    tabla.Rows[4].Cells[0].Value = 'D';

                    tabla.Rows[0].Cells[5].Value = 'E';
                    tabla.Rows[5].Cells[0].Value = 'E';


                    if (aux >= 6)
                    {
                        tabla.Rows[0].Cells[6].Value = 'F';
                        tabla.Rows[6].Cells[0].Value = 'F';

                        if (aux>=7)
                        {
                            tabla.Rows[0].Cells[7].Value = 'G';
                            tabla.Rows[7].Cells[0].Value = 'G';

                            if (aux >= 8)
                            {
                                tabla.Rows[0].Cells[8].Value = 'H';
                                tabla.Rows[8].Cells[0].Value = 'H';

                                if (aux >= 9)
                                {

                                    tabla.Rows[0].Cells[9].Value = 'I';
                                    tabla.Rows[9].Cells[0].Value = 'I';

                                    if (aux >= 10)
                                    {

                                        tabla.Rows[0].Cells[10].Value = 'J';
                                        tabla.Rows[10].Cells[0].Value = 'J';

                                        if (aux >= 11)
                                        {
                                            tabla.Rows[0].Cells[11].Value = 'K';
                                            tabla.Rows[11].Cells[0].Value = 'K';

                                            if (aux >= 12)
                                            {
                                                tabla.Rows[0].Cells[12].Value = 'L';
                                                tabla.Rows[12].Cells[0].Value = 'L';


                                                if (aux >= 13)
                                                {

                                                    tabla.Rows[0].Cells[13].Value = 'M';
                                                    tabla.Rows[13].Cells[0].Value = 'M';

                                                    if (aux >= 14)
                                                    {

                                                        tabla.Rows[0].Cells[14].Value = 'N';
                                                        tabla.Rows[14].Cells[0].Value = 'N';

                                                        if (aux >= 15)
                                                        {
                                                            tabla.Rows[0].Cells[15].Value = 'Ñ';
                                                            tabla.Rows[15].Cells[0].Value = 'Ñ';


                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }





                    tabla.Rows[i].Cells[j].Value = MatrizPrincipal[i, j].ToString();
                }
            }


            ///

            if (aux >= 5)
            {

                Node NodeA = new Node() { Ciudad = "A" };
                Node NodeB = new Node() { Ciudad = "B" };
                Node NodeC = new Node() { Ciudad = "C" };
                Node NodeD = new Node() { Ciudad = "D" };
                Node NodeE = new Node() { Ciudad = "E" };

                NodeA.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 1] });
                NodeA.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 1] });
                NodeA.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 1] });
                NodeA.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 1] });

                NodeB.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 2] });
                NodeB.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 2] });
                NodeB.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 2] });
                NodeB.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 2] });

                NodeC.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 3] });
                NodeC.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 3] });
                NodeC.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 3] });
                NodeC.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 3] });

                NodeD.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 4] });
                NodeD.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 4] });
                NodeD.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 4] });
                NodeD.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 4] });

                NodeE.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 5] });
                NodeE.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 5] });
                NodeE.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 5] });
                NodeE.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 5] });

                if (aux == 5)
                {
                   

                    List<Node> grafo = new List<Node>()
                    {

                      NodeA,NodeB,NodeC,NodeD,NodeE
                     };
                    var algoritmo = new Algoritmo(grafo, 20, NodeA);
                    algoritmo.Recorre();


                    vista.Text=(algoritmo.ObtenerTodasLasRutas);

                  
                }

                else if (aux >= 6)
                {
                    Node NodeF = new Node() { Ciudad = "F" };

                    NodeA.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 1] });
                    NodeB.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 2] });
                    NodeC.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 3] });
                    NodeD.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 4] });
                    NodeE.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 5] });


                    NodeF.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 6] });
                    NodeF.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 6] });
                    NodeF.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 6] });
                    NodeF.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 6] });
                    NodeF.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 6] });

                    if (aux == 6)
                    {
                       

                        List<Node> grafo = new List<Node>()
                        {

                             NodeA,NodeB,NodeC,NodeD,NodeE,NodeF
                        };
                        var algoritmo = new Algoritmo(grafo, 20, NodeA);
                        algoritmo.Recorre();
                         vista.Text=(algoritmo.ObtenerTodasLasRutas);

                      
                    }
                    else if (aux >= 7)
                    {
                        Node NodeG = new Node() { Ciudad = "G" };

                        NodeA.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 1] });
                        NodeB.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 2] });
                        NodeC.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 3] });
                        NodeD.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 4] });
                        NodeE.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 5] });
                        NodeF.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 6] });


                        NodeG.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 7] });
                        NodeG.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 7] });
                        NodeG.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 7] });
                        NodeG.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 7] });
                        NodeG.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 7] });
                        NodeG.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 7] });



                        if (aux == 7)
                        {
                            List<Node> grafo = new List<Node>()
                             {

                               NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG

                             };
                            var algoritmo = new Algoritmo(grafo, 20, NodeA);
                            algoritmo.Recorre();
                            vista.Text = (algoritmo.ObtenerTodasLasRutas);
                        }

                        else if (aux >= 8)
                        {
                            Node NodeH = new Node() { Ciudad = "H" };

                            NodeA.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 1] });
                            NodeB.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 2] });
                            NodeC.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 3] });
                            NodeD.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 4] });
                            NodeE.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 5] });
                            NodeF.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 6] });
                            NodeG.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 7] });

                            NodeH.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 8] });
                            NodeH.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 8] });
                            NodeH.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 8] });
                            NodeH.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 8] });
                            NodeH.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 8] });
                            NodeH.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 8] });
                            NodeH.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 8] });


                            if (aux == 8)
                            {
                                List<Node> grafo = new List<Node>()
                             {

                                 NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG,NodeH
                              };
                                var algoritmo = new Algoritmo(grafo, 20, NodeA);
                                algoritmo.Recorre();
                                vista.Text = (algoritmo.ObtenerTodasLasRutas);
                            }



                            else if (aux >= 9)
                            {
                                Node NodeI = new Node() { Ciudad = "I" };

                                NodeA.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 1] });
                                NodeB.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 2] });
                                NodeC.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 3] });
                                NodeD.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 4] });
                                NodeE.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 5] });
                                NodeF.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 6] });
                                NodeG.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 7] });
                                NodeH.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 8] });

                                NodeI.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 9] });
                                NodeI.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 9] });
                                NodeI.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 9] });
                                NodeI.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 9] });
                                NodeI.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 9] });
                                NodeI.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 9] });
                                NodeI.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 9] });
                                NodeI.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 9] });

                                if (aux == 9)
                                {
                                    List<Node> grafo = new List<Node>()
                                 {

                                    NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG,NodeH,NodeI
                                 };
                                    var algoritmo = new Algoritmo(grafo, 20, NodeA);
                                    algoritmo.Recorre();
                                    vista.Text = (algoritmo.ObtenerTodasLasRutas);
                                }


                                else if (aux >= 10)
                                {
                                    Node NodeJ = new Node() { Ciudad = "J" };

                                    NodeA.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 1] });
                                    NodeB.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 2] });
                                    NodeC.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 3] });
                                    NodeD.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 4] });
                                    NodeE.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 5] });
                                    NodeF.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 6] });
                                    NodeG.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 7] });
                                    NodeH.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 8] });
                                    NodeI.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 9] });

                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 10] });
                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 10] });
                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 10] });
                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 10] });
                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 10] });
                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 10] });
                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 10] });
                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 10] });
                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 10] });

                                    if (aux == 10)
                                    {
                                        List<Node> grafo = new List<Node>()
                                    {

                                      NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG,NodeH,NodeI,NodeJ
                                     };
                                        var algoritmo = new Algoritmo(grafo, 20, NodeA);
                                        algoritmo.Recorre();
                                        vista.Text = (algoritmo.ObtenerTodasLasRutas);
                                    }

                                    else if (aux >= 11)
                                    {
                                        Node NodeK = new Node() { Ciudad = "K" };

                                        NodeA.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 1] });
                                        NodeB.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 2] });
                                        NodeC.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 3] });
                                        NodeD.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 4] });
                                        NodeE.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 5] });
                                        NodeF.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 6] });
                                        NodeG.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 7] });
                                        NodeH.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 8] });
                                        NodeI.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 9] });
                                        NodeJ.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 10] });

                                        NodeK.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 11] });
                                        NodeK.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 11] });

                                        if (aux == 11)
                                        {
                                            List<Node> grafo = new List<Node>()
                                         {

                                               NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG,NodeH,NodeI,NodeJ,NodeK
                                               };
                                            var algoritmo = new Algoritmo(grafo, 20, NodeA);
                                            algoritmo.Recorre();
                                            vista.Text = (algoritmo.ObtenerTodasLasRutas);
                                        }
                                        else if (aux >= 12)
                                        {
                                            Node NodeL = new Node() { Ciudad = "L" };

                                            NodeA.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 1] });
                                            NodeB.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 2] });
                                            NodeC.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 3] });
                                            NodeD.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 4] });
                                            NodeE.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 5] });
                                            NodeF.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 6] });
                                            NodeG.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 7] });
                                            NodeH.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 8] });
                                            NodeI.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 9] });
                                            NodeJ.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 10] });
                                            NodeK.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 11] });

                                            NodeL.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 12] });
                                            NodeL.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 12] });

                                            if (aux == 12)
                                            {
                                                List<Node> grafo = new List<Node>()
                                             {

                                                    NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG,NodeH,NodeI,NodeJ,NodeK,NodeL
                                              };
                                                var algoritmo = new Algoritmo(grafo, 20, NodeA);
                                                algoritmo.Recorre();
                                                vista.Text = (algoritmo.ObtenerTodasLasRutas);
                                            }


                                            else if (aux >= 13)
                                            {
                                                Node NodeM = new Node() { Ciudad = "M" };

                                                NodeA.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 1] });
                                                NodeB.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 2] });
                                                NodeC.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 3] });
                                                NodeD.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 4] });
                                                NodeE.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 5] });
                                                NodeF.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 6] });
                                                NodeG.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 7] });
                                                NodeH.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 8] });
                                                NodeI.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 9] });
                                                NodeJ.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 10] });
                                                NodeK.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 11] });
                                                NodeL.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 12] });

                                                NodeM.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 13] });
                                                NodeM.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 13] });

                                                if (aux == 13)
                                                {
                                                    List<Node> grafo = new List<Node>()
                                                 {

                                                   NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG,NodeH,NodeI,NodeJ,NodeK,NodeL,NodeM
                                                 };
                                                    var algoritmo = new Algoritmo(grafo, 20, NodeA);
                                                    algoritmo.Recorre();
                                                    vista.Text = (algoritmo.ObtenerTodasLasRutas);
                                                }

                                                else if (aux >= 14)
                                                {
                                                    Node NodeN = new Node() { Ciudad = "N" };

                                                    NodeA.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 1] });
                                                    NodeB.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 2] });
                                                    NodeC.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 3] });
                                                    NodeD.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 4] });
                                                    NodeE.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 5] });
                                                    NodeF.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 6] });
                                                    NodeG.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 7] });
                                                    NodeH.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 8] });
                                                    NodeI.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 9] });
                                                    NodeJ.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 10] });
                                                    NodeK.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 11] });
                                                    NodeL.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 12] });
                                                    NodeM.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 13] });

                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 14] });
                                                    NodeN.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 14] });

                                                    if (aux == 14)
                                                    {
                                                        List<Node> grafo = new List<Node>()
                                                      {

                                                          NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG,NodeH,NodeI,NodeJ,NodeK,NodeL,NodeM,NodeN
                                                          };
                                                        var algoritmo = new Algoritmo(grafo, 20, NodeA);
                                                        algoritmo.Recorre();
                                                        vista.Text = (algoritmo.ObtenerTodasLasRutas);
                                                    }
                                                    else if (aux >= 15)
                                                    {
                                                        Node NodeO = new Node() { Ciudad = "Ñ" };

                                                        NodeA.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 1] });
                                                        NodeB.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 2] });
                                                        NodeC.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 3] });
                                                        NodeD.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 4] });
                                                        NodeE.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 5] });
                                                        NodeF.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 6] });
                                                        NodeG.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 7] });
                                                        NodeH.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 8] });
                                                        NodeI.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 9] });
                                                        NodeJ.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 10] });
                                                        NodeK.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 11] });
                                                        NodeL.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 12] });
                                                        NodeM.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 13] });
                                                        NodeN.Camino.Add(new Camino() { Nodo = NodeO, distance = MatrizPrincipal[15, 14] });


                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeA, distance = MatrizPrincipal[1, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeB, distance = MatrizPrincipal[2, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeC, distance = MatrizPrincipal[3, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeD, distance = MatrizPrincipal[4, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeE, distance = MatrizPrincipal[5, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeF, distance = MatrizPrincipal[6, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeG, distance = MatrizPrincipal[7, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeH, distance = MatrizPrincipal[8, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeI, distance = MatrizPrincipal[9, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeJ, distance = MatrizPrincipal[10, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeK, distance = MatrizPrincipal[11, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeL, distance = MatrizPrincipal[12, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeM, distance = MatrizPrincipal[13, 15] });
                                                        NodeO.Camino.Add(new Camino() { Nodo = NodeN, distance = MatrizPrincipal[14, 15] });
                                                        if (aux == 15)
                                                        {
                                                            List<Node> grafo = new List<Node>()
                                                            {

                                                             NodeA,NodeB,NodeC,NodeD,NodeE,NodeF,NodeG,NodeH,NodeI,NodeJ,NodeK,NodeL,NodeM,NodeN,NodeO
                                                            };
                                                            var algoritmo = new Algoritmo(grafo, 20, NodeA);
                                                            algoritmo.Recorre();
                                                            vista.Text = (algoritmo.ObtenerTodasLasRutas);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //gato
        }
    }

    public class Algoritmo
    {
        private List<Node> grafo { get; set; }

        private int n;
        private Node origen { get; set; }
        private List<Rutas> soluciones { get; set; }

        public string ObtenerTodasLasRutas
        {
            get
            {
                string resultado = "";
                ListViewItem lsw1 = new ListViewItem();

                foreach (var rutas in soluciones)
                {
                    foreach (var nodo in rutas.Nodos)
                    {
                        resultado += nodo.Ciudad + ",";
                    }
                    resultado += " " + rutas.DistanciaTotal+"\n" ;
                }


                return resultado;
            }
        }

        public Algoritmo(List<Node> grafoo, int n, Node origen)
        {
            grafo = grafoo;
            this.n = n;
            this.origen = origen;
        }
        public void Recorre()
        {
            soluciones = new List<Rutas>();

            for (int i = 0; i < n; i++)
            {
                soluciones.Add(Generar());
            }
            soluciones = soluciones.OrderBy(d => d.DistanciaTotal).ToList();

        }

        private Rutas Generar()
        {
            var solucioon = new Rutas();

            solucioon.Nodos.Add(origen);

            Node current = origen;


            for (int i = 0; i < grafo.Count - 1; i++)
            {
                Node next = null;
                do
                {
                    next = Siguiente_Nodo(current);
                } while (solucioon.Nodos.Contains(next));

                solucioon.Nodos.Add(next);
                solucioon.DistanciaTotal += current.Camino.Where(d => d.Nodo.Ciudad == next.Ciudad).First().distance;

                current = next;
            }

            solucioon.Nodos.Add(origen);
            solucioon.DistanciaTotal += current.Camino.Where(d => d.Nodo.Ciudad == origen.Ciudad).First().distance;
            return solucioon;
        }

        private Node Siguiente_Nodo(Node current)
        {
            int NextNode = new Random().Next(0, grafo.Count - 1);

            return current.Camino[NextNode].Nodo;
        }
    }

    public class Node
    {
        public string Ciudad { get; set; }

        public List<Camino> Camino { get; set; }

        public Node()
        {
            Camino = new List<Camino>();
        }
    }

    public struct Camino
    {
        public Node Nodo { get; set; }

        public int distance { get; set; }
    }

    public class Rutas
    {
        public List<Node> Nodos { get; set; }
        public int DistanciaTotal { get; set; }

        public Rutas()
        {
            Nodos = new List<Node>();
            DistanciaTotal = 0;
        }
    }

}
