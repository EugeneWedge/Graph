using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graph.Algorithms;
using Graph.Graph;
namespace Graph
{
    public partial class Main : Form
    {
        /// <summary>
        /// Изменяется при открытии графа с файла
        /// </summary>
        bool FlagGeneration = false;
        /// <summary>
        /// Кол-во созданных рёбер
        /// </summary>
        static int QuantityEdges = 0;
        /// <summary>
        /// Переменная для сравнения число вершин стало больше или меньше
        /// </summary>
        static int NumericUpDown = 0;
        /// <summary>
        /// Лист с вершинами
        /// </summary>
       static List<Label> LabelVertex = new List<Label>();
       static Bitmap map = new Bitmap(1029, 434);
        /// <summary>
        /// Место отрисовки
        /// </summary>
       static Graphics graphics = Graphics.FromImage(map);
        /// <summary>
        /// Кисточка
        /// </summary>
       static Pen pen = new Pen(Color.Black, 3f);
        /// <summary>
        /// Граф
        /// </summary>
       static Graphh graph = new Graphh();
       static int[,] GetMatrix;
       static int[,] GetMatrixFord;
        /// <summary>
        /// Матрица с минимальными расстояниями до каждой вершины
        /// </summary>
        static int[,] GetMatrixDistanceFloyd;
        /// <summary>
        /// После создания вершины, меняет минимальное кол-во вершин на 1
        /// </summary>
       static bool NumericUpDownVertex = true;
        /// <summary>
        /// Время выполнения функции
        /// </summary>
       static Stopwatch sw;
        public Main()
        {
            InitializeComponent();
            saveFileDialog_DataGridView.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // Подсказки
            ToolTip t = new ToolTip();
            t.SetToolTip(Button_ADijkstra, "Алгоритм Дейкстра");
            t.SetToolTip(Button_AFloydWarshal, "Алгоритм Флойда Варшала");
            t.SetToolTip(Button_AFordBellman, "Алгоритм Форда Белмана");
            t.SetToolTip(button_InformationAuthor, "Інформація про автора");
            t.SetToolTip(button_InformationApp, "Інформація про программу");
            t.SetToolTip(button_Reset, "Перезапуск програми");
            t.SetToolTip(button_SaveMatrix, "Збереження матриці");
            t.SetToolTip(button_SaveResult, "Збереження рішення");
            t.SetToolTip(button_SaveResultTest, "Збереження швидкості виконання алгоритму");
            t.SetToolTip(button_Random, "Рандомне створення ребер");
            t.SetToolTip(button_LoadGraph, "Загрузка графа з файла");
            t.SetToolTip(button_Tests, "Тестування алгоритмів");
            // Добавляем каждый Label представляющий вершину в list
            LabelVertex.Add(label_Vertex1);
            LabelVertex.Add(label_Vertex2);
            LabelVertex.Add(label_Vertex3);
            LabelVertex.Add(label_Vertex4);
            LabelVertex.Add(label_Vertex5);
            LabelVertex.Add(label_Vertex6);
            LabelVertex.Add(label_Vertex7);
            LabelVertex.Add(label_Vertex8);
            LabelVertex.Add(label_Vertex9);
            LabelVertex.Add(label_Vertex10);
        }
        /// <summary>
        /// Добавления или убавления вершин
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_Vertex_ValueChanged(object sender, EventArgs e)
        {
            pictureBox_Graphics.Focus();
            if (NumericUpDownVertex)
            {
            // После создания вершины изменяем минимальное кол-во вершин на 1
            numericUpDown_Vertex.Minimum = 1;
            NumericUpDownVertex = false;
            }
            // Выбор вершины
            int index = (int)numericUpDown_Vertex.Value;
            if (index > NumericUpDown)
            {
                // Добавление вершины
                graph.AddVertex((int)numericUpDown_Vertex.Value);
                LabelVertex[index-1].Visible = true;
                // Изменение кол-во колонок и столбцов в DataGridView
                dataGridView.Columns.Add(index.ToString(), index.ToString());
                // Программное добавление строк
                dataGridView.Rows.Add();
                // Заголовок строки
                dataGridView.Rows[index - 1].HeaderCell.Value = index.ToString();
                // Ширина строки
                dataGridView.Columns[index - 1].Width = 30;
                //==============================================
                // Изменение кол-во колонок и столбцов в DataGridView
                dataGridView_Result.Columns.Add(index.ToString(), index.ToString());
                // Программное добавление строк
                dataGridView_Result.Rows.Add();
                // Заголовок строки
                dataGridView_Result.Rows[index - 1].HeaderCell.Value = index.ToString();
                // Ширина строки
                dataGridView_Result.Columns[index - 1].Width = 30;
            }
            else
            {
                // Удаление вершины
                graph.RemoveVertex((int)numericUpDown_Vertex.Value);
                LabelVertex[index].Visible = false;
                dataGridView.Columns.Remove((index+1).ToString());
                dataGridView.Rows.RemoveAt(index);
                //==============================================
                dataGridView_Result.Columns.Remove((index + 1).ToString());
                dataGridView_Result.Rows.RemoveAt(index);
            }
            NumericUpDown = index;

            // Максимальное значение для выбора рёбер
            numericUpDown_VertexStart.Maximum = index;
            numericUpDown_VertexEnd.Maximum = index;

            // Делает видимым поле для добавления рёбер
            if (index >= 2)
                groupBox_Edges.Enabled = true;
            else
                groupBox_Edges.Enabled = false;

        }
        /// <summary>
        /// Отрисовка рёбер между вершинами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddEdge_Click(object sender, EventArgs e)
        {
            QuantityEdges++;
            pictureBox_Graphics.Focus();
            // Предоставляет доступ к алгоритмам поиска
            Button_ADijkstra.Enabled = true;
            Button_AFloydWarshal.Enabled = true;
            Button_AFordBellman.Enabled = true;
            button_SaveMatrix.Enabled = true;
            button_SaveResult.Enabled = true;
            button_SaveResultTest.Enabled = true;
            // Блокировка изменения кол-во вершин после добавления ребра
            numericUpDown_Vertex.Minimum = numericUpDown_VertexEnd.Value;
            // Добавление рёбер
            graph.AddEdge((int)numericUpDown_VertexStart.Value, (int)numericUpDown_VertexEnd.Value, (int)numericUpDown_VertexWeight.Value);
            GetMatrix = graph.GetMatrix();
            for (int i = 0; i < GetMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GetMatrix.GetLength(1); j++)
                {
                    dataGridView[i, j].Value = GetMatrix[i, j];
                }
            }
            // Коррекция отрисовки линий
            int Correction = 10;
            // Индекс начальной вершины
            int indexA = (int)numericUpDown_VertexStart.Value-1;
            // Индекс конечной вершины
            int indexB = (int)numericUpDown_VertexEnd.Value-1;
            // Вершина начальная
            Label A = LabelVertex[indexA];
            // Вершина конечная
            Label B = LabelVertex[indexB];
            graphics.DrawLine(pen, A.Location.X+Correction, A.Location.Y+Correction, B.Location.X+Correction, B.Location.Y+Correction);
            pictureBox_Graphics.Image = map;
        }
        /// <summary>
        /// Перезапуск формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        /// <summary>
        /// Поиск короткого пути Алгоритм Флойда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AFloydWarshal_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox_Graphics.Focus();
                sw = new Stopwatch();
                sw.Start();
                GetMatrixDistanceFloyd = AFloydWarshal.FloydWarshall(GetMatrix);
                for (int i = 0; i < GetMatrixDistanceFloyd.GetLength(0); i++)
                {
                    for (int j = 0; j < GetMatrixDistanceFloyd.GetLength(1); j++)
                    {
                        dataGridView_Result[i, j].Value = GetMatrixDistanceFloyd[i, j];
                    }
                }
                sw.Stop();
                richTextBox_Test.Text += "=================================\n";
                richTextBox_Test.Text += $"Час виконання\nАлгоритма Флойда Варшала\n{sw.Elapsed} мілісекунд!";
            }
            catch
            {
                MessageBox.Show("Помилка", "Виникла якась помилка!");
            }
        }
        /// <summary>
        /// Поиск короткого пути Алгоритм Дейкстра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ADijkstra_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox_Result.Text += "\n=============================================================\n";
                pictureBox_Graphics.Focus();
                sw = new Stopwatch();
                sw.Start();
                for (int i = 0; i < GetMatrix.GetLength(0); i++)
                {
                    ADijkstra.dijkstra(GetMatrix, i, richTextBox_Result);
                    richTextBox_Result.Text += "\n";
                }
                sw.Stop();
                richTextBox_Test.Text += "=================================\n";
                richTextBox_Test.Text += $"Час виконання\nАлгоритма Дейкстра\n{sw.Elapsed} мілісекунд!\n";
            }
            catch
            {
                MessageBox.Show("Помилка", "Виникла якась помилка!");
            }

        }

        /// <summary>
        /// Поиск короткого пути Алгоритм Форда Белмана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_AFordBellman_Click_1(object sender, EventArgs e)
        {
            try
            {
                richTextBox_Result.Text += "\n=============================================================\n";
                pictureBox_Graphics.Focus();
                GetMatrixFord = new int[graph.CountEdges(), 3];
                int i = 0;
                foreach (var item in graph.Edges)
                {
                    GetMatrixFord[i, 0] = item.VertexStart.NumberVertex - 1;
                    GetMatrixFord[i, 1] = item.VertexEnd.NumberVertex - 1;
                    GetMatrixFord[i, 2] = item.Weight;
                    i++;
                }
                sw = new Stopwatch();
                sw.Start();
                for (int j = 0; j < NumericUpDown; j++)
                {
                    richTextBox_Result.Text += $"Мінімальна відстань до вершини {j + 1}\n";
                    ABellmanFord.BellmanFord(GetMatrixFord, NumericUpDown, graph.CountEdges(), j, richTextBox_Result);
                }
                sw.Stop();
                richTextBox_Test.Text += "\n=================================\n";
                richTextBox_Test.Text += $"Час виконання\nАлгоритма Белмана Форда\n{sw.Elapsed} мілісекунд!";
            }
            catch
            {
                MessageBox.Show("Помилка", "Виникла якась помилка!");
            }
        }
        /// <summary>
        /// Информация об авторе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_InformationAuthor_Click(object sender, EventArgs e)
        {
            InformationAuthor informationAuthor = new InformationAuthor();
            informationAuthor.Show();
        }

        private void button_InformationApp_Click(object sender, EventArgs e)
        {
            InformationApp informationApp = new InformationApp();
            informationApp.Show();
        }
        /// <summary>
        /// Сохранение матрицы смежности в текстовый документ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SaveMatrix_Click(object sender, EventArgs e)
        {
            string TextMatrix = "";

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView.Rows.Count; j++)
                {
                    TextMatrix += dataGridView[i, j].Value.ToString();
                    if (j != (dataGridView.Columns.Count - 1))
                        TextMatrix += " ";
                    if (j == (dataGridView.Rows.Count - 1))
                        TextMatrix += "\n";
                }
            }

            if (saveFileDialog_DataGridView.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog_DataGridView.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, TextMatrix);
            MessageBox.Show("Файл сохранен");
        }
        /// <summary>
        /// Сохранение результата коротких путей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SaveResult_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_DataGridView.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog_DataGridView.FileName;
            System.IO.File.WriteAllText(filename, richTextBox_Result.Text);
            MessageBox.Show("Файл сохранен");
        }
        /// <summary>
        /// Сохранение результатов скорости выполения алгоритмов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SaveResultTest_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_DataGridView.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog_DataGridView.FileName;
            System.IO.File.WriteAllText(filename, richTextBox_Test.Text);
            MessageBox.Show("Файл сохранен");
        }
        /// <summary>
        /// Рандомное заполение рёбер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            QuantityEdges++;
            pictureBox_Graphics.Focus();
            // Предоставляет доступ к алгоритмам поиска
            Button_ADijkstra.Enabled = true;
            Button_AFloydWarshal.Enabled = true;
            Button_AFordBellman.Enabled = true;
            button_SaveMatrix.Enabled = true;
            button_SaveResult.Enabled = true;
            button_SaveResultTest.Enabled = true;
            // Блокировка изменения кол-во вершин после добавления ребра
            numericUpDown_Vertex.Minimum = numericUpDown_Vertex.Value;
            // Добавление рёбер
            for (int k = 0; k < numericUpDown_Vertex.Value; k++)
            {
                for (int c = k+1; c < numericUpDown_Vertex.Value; c++)
                {
                    graph.AddEdge(k+1, c+1, random.Next(100));
                     GetMatrix = graph.GetMatrix();
            for (int i = 0; i < GetMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GetMatrix.GetLength(1); j++)
                {
                    dataGridView[i, j].Value = GetMatrix[i, j];
                }
            }
            // Коррекция отрисовки линий
            int Correction = 10;
            // Индекс начальной вершины
            int indexA = k;
            // Индекс конечной вершины
            int indexB = c;
            // Вершина начальная
            Label A = LabelVertex[indexA];
            // Вершина конечная
            Label B = LabelVertex[indexB];
            graphics.DrawLine(pen, A.Location.X + Correction, A.Location.Y + Correction, B.Location.X + Correction, B.Location.Y + Correction);
            pictureBox_Graphics.Image = map;
                }
            }
        }
        /// <summary>
        /// Загрузка графа с файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_LoadGraph_Click(object sender, EventArgs e)
        {
            string TextMatrix = "";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFile.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            TextMatrix = fileText;
            /// Подсчёт всех вхождений элемента поиска
            int startIndex = 0;
            int RowsCount = 0;
            int ColumnsCount = 0;
            while (true)
            {
                startIndex = TextMatrix.IndexOf(
                    '\n', startIndex + 1,
                    TextMatrix.Length - startIndex - 1);

                // Выйти из цикла, если цель не найдена.
                if (startIndex < 0)
                    break;
                RowsCount++;
            }
            string[] wordsMatrix = TextMatrix.Split(new char[] { '\n', ' ' });
            ColumnsCount = (wordsMatrix.Length - 1) / RowsCount;
            GetMatrix = new int[RowsCount, ColumnsCount];
            for (int i = 0, c = 0; i < GetMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GetMatrix.GetLength(1); j++)
                {
                    try
                    {
                        GetMatrix[i, j] = int.Parse(wordsMatrix[c]);
                        c++;
                        FlagGeneration = true;
                    }
                    catch
                    {
                        MessageBox.Show("Возникли проблемы со считыванием файла");
                        FlagGeneration = false;
                        break;
                    }
                }
            }
            // Создание колонок и столбцов
            for (int i = 0; i < GetMatrix.GetLength(0); i++)
            {
                int index = i + 1;
            numericUpDown_Vertex.Value = index;
            }
            // Заполнение dataGridView
            for (int i = 0; i < GetMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < GetMatrix.GetLength(1); j++)
                {
                    dataGridView[i, j].Value = GetMatrix[i, j];
                }
            }
            // Отрисовка рёбер
            QuantityEdges++;
            pictureBox_Graphics.Focus();
            // Предоставляет доступ к алгоритмам поиска
            Button_ADijkstra.Enabled = true;
            Button_AFloydWarshal.Enabled = true;
            Button_AFordBellman.Enabled = true;
            button_SaveMatrix.Enabled = true;
            button_SaveResult.Enabled = true;
            button_SaveResultTest.Enabled = true;
            // Блокировка изменения кол-во вершин после добавления ребра
            numericUpDown_Vertex.Minimum = numericUpDown_VertexEnd.Value;
            // Добавление рёбер
            for (int i = 0; i < numericUpDown_Vertex.Value; i++)
            {
                for (int j = 0; j < numericUpDown_Vertex.Value; j++)
                {
                    graph.AddEdge(i+1, j+1, GetMatrix[i,j]);
                    // Коррекция отрисовки линий
                    int Correction = 10;
                    // Индекс начальной вершины
                    int indexA = i;
                    // Индекс конечной вершины
                    int indexB = j;
                    // Вершина начальная
                    Label A = LabelVertex[indexA];
                    // Вершина конечная
                    Label B = LabelVertex[indexB];
                    graphics.DrawLine(pen, A.Location.X + Correction, A.Location.Y + Correction, B.Location.X + Correction, B.Location.Y + Correction);
                    pictureBox_Graphics.Image = map;
                }
            }

            if (FlagGeneration)
            {
                MessageBox.Show("Файл открыт");
            }
        }

        private void button_Tests_Click(object sender, EventArgs e)
        {
            MethodTests methodTests = new MethodTests();
            methodTests.Show();
        }
    }
}
