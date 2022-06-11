using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graph.Algorithms;
using Graph.Graph;
namespace Graph
{
    public partial class MethodTests : Form
    {
        Stopwatch sw = new Stopwatch();
        int[,] GetMatrix;
        static Graphh graph;
        public MethodTests()
        {
            ToolTip t = new ToolTip();
            InitializeComponent();
            t.SetToolTip(button_Test1, "Алгоритм Белмана Форда");
            t.SetToolTip(button_Test2, "Алгоритм Дейкстра");
            t.SetToolTip(button_Test3, "Алгоритм Флойда Варшала");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox_Test.Text = String.Empty;
            graph = new Graphh();
            Random random = new Random();
            await Task.Run(() =>
            {
                for (int i = 0; i < numericUpDown_Vertex.Value; i++)
                {
                    graph.AddVertex(i + 1);
                    richTextBox_Test.Text += $"\nСтворена вершина: {i + 1}";
                }
                for (int k = 0; k < numericUpDown_Vertex.Value; k++)
                {
                    for (int c = k + 1; c < numericUpDown_Vertex.Value; c++)
                    {
                        graph.AddEdge(k + 1, c + 1, random.Next(400));
                    }
                }
                GetMatrix = graph.GetMatrix();
                richTextBox_Test.Text += "\n";
            });
            button_Test1.Enabled = true;
            button_Test2.Enabled = true;
            button_Test3.Enabled = true;
            MessageBox.Show("Вершини та ребра між ними створені", "Повідомлення");
        }
        /// <summary>
        /// Алгоритм Форда Беллмана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_Test1_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] GetMatrixFord;
                GetMatrixFord = new int[graph.CountEdges(), 3];
                int i = 0;
                await Task.Run(() =>
                {
                    foreach (var item in graph.Edges)
                    {
                        GetMatrixFord[i, 0] = item.VertexStart.NumberVertex - 1;
                        GetMatrixFord[i, 1] = item.VertexEnd.NumberVertex - 1;
                        GetMatrixFord[i, 2] = item.Weight;
                        i++;
                    }
                    sw = new Stopwatch();
                    sw.Start();
                    for (int j = 0; j < numericUpDown_Vertex.Value; j++)
                    {
                        ABellmanFord.BellmanFord(GetMatrixFord, (int)numericUpDown_Vertex.Value, graph.CountEdges(), j, new RichTextBox());
                    }
                });
                sw.Stop();
                richTextBox_Test.Text += $"\nЧас виконання\nАлгоритма Белмана Форда\n{sw.Elapsed} мілісекунд!\n";
            }
            catch
            {
                MessageBox.Show("Помилка", "Виникла якась помилка!");
            }
        }
        /// <summary>
        /// Алгоритм Дейкстра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_Test2_Click(object sender, EventArgs e)
        {
            try
            {
                sw = new Stopwatch();
                sw.Start();
                await Task.Run(() =>
                {
                    for (int i = 0; i < GetMatrix.GetLength(0); i++)
                    {
                        ADijkstra.dijkstra(GetMatrix, i, new RichTextBox());
                    }
                });
                sw.Stop();
                richTextBox_Test.Text += $"\nЧас виконання\nАлгоритма Дейкстра\n{sw.Elapsed} мілісекунд!\n";
            }
            catch
            {
                MessageBox.Show("Помилка", "Виникла якась помилка!");
            }
        }
        /// <summary>
        /// Алгоритм Флойда Варшала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_Test3_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] GetMatrixDistanceFloyd;
                sw = new Stopwatch();
                sw.Start();
                await Task.Run(() => { GetMatrixDistanceFloyd = AFloydWarshal.FloydWarshall(GetMatrix);});
                sw.Stop();
                richTextBox_Test.Text += $"\nЧас виконання\nАлгоритма Флойда Варшала\n{sw.Elapsed} мілісекунд!\n";
            }
            catch
            {
                MessageBox.Show("Помилка", "Виникла якась помилка!");
            }
        }
        /// <summary>
        /// Очистка поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_Test.Text = String.Empty;
        }
    }
}
