# Интегрл
Дорабоатать области инеграла и сделать так что бы они могли принимать корни и какие либо другие мат значения 
````
private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string formul = InputF.Text;

            double x1 = Convert.ToDouble(Inputx1.Text);
            double x2 = Convert.ToDouble(Inputx2.Text);
            double y1 = Convert.ToDouble(Inputy1.Text);
            double y2 = Convert.ToDouble(Inputy2.Text);

            double rez = DoubleIntegral(x1, x2, y2, y1, 100, 100, formul);
            ReturnResult.Text = Convert.ToString(rez);

        }
````
___
# Доделать
* 1 Внешний вид интерфейса
* 2 Протестировать 

# основной алгоритм посчёта 
````
static double DoubleIntegral(double a1, double b1, double a2, double b2, int n1, int n2, string formul)
        {
            double h1 = (b1 - a1) / n1;
            double h2 = (b2 - a2) / n2;
            double sum = 0;

            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    double x = a1 + i * h1 + h1 / 2;
                    double y = a2 + j * h2 + h2 / 2;
                    sum += Function(x, y, formul) * h1 * h2;
                }
            }

            return sum;
        }
````

# XML
````
<Window x:Class="Интегрл.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Интегрл"
        mc:Ignorable="d"
        Title="Двойной интеграл" Height="350" Width="420" WindowStyle="ThreeDBorderWindow">
    <Grid x:Name="MainRoot" Background='White'>
        <Button x:Name="Rexult" Content="Решить" HorizontalAlignment="Left" Margin="297,251,0,0" VerticalAlignment="Top" Height="52" Width="93" Click="Button_Click_1"/>
        <TextBlock x:Name ="ReturnResult" HorizontalAlignment="Left" Margin="18,251,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Height="52" Width="268" FontStyle="Italic"><Run Language="ru-ru" Text="Ответ"/></TextBlock>
        <TextBox x:Name ="InputF" HorizontalAlignment="Left" Margin="18,40,0,0" TextWrapping="Wrap" Text="" VerticalAlignment="Top" Width="372" Height="62" TextChanged="TextBox_TextChanged"/>
        <TextBlock HorizontalAlignment="Left" Margin="18,19,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="141"><Run Language="ru-ru" Text="Введите интеграл"/></TextBlock>
        <TextBlock HorizontalAlignment="Left" Margin="18,111,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Height="14" Width="141"><Run Language="ru-ru" Text="В"/><Run Text="ведите предел"/><Run Language="ru-ru" Text="ы "/><Run Text="x1 y1"/></TextBlock>
        <TextBox x:Name="Inputx1" HorizontalAlignment="Left" Margin="18,0,0,0" TextWrapping="Wrap" Text="" VerticalAlignment="Center" Width="61" Height="37" TextChanged="TextBox_TextChanged_1"/>
        <TextBox x:Name="Inputy1" HorizontalAlignment="Left" Margin="18,202,0,0" TextWrapping="Wrap" Text="" VerticalAlignment="Top" Width="61" Height="37" TextChanged="TextBox_TextChanged_1"/>
        <TextBox x:Name="Inputx2" HorizontalAlignment="Left" Margin="88,202,0,0" TextWrapping="Wrap" Text="" VerticalAlignment="Top" Width="62" Height="37" TextChanged="TextBox_TextChanged_1"/>
        <TextBox x:Name="Inputy2" HorizontalAlignment="Left" Margin="88,0,0,0" TextWrapping="Wrap" Text="" VerticalAlignment="Center" Width="61" Height="37" TextChanged="TextBox_TextChanged_1"/>
        <TextBlock HorizontalAlignment="Left" Margin="18,184,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Height="14" Width="141"><Run Text="В"/><Run Text="ведите предел"/><Run Text="ы "/><Run Text="x2 y2"/></TextBlock>

    </Grid>
</Window>
````

# Источники информации 
* [Решение двойного инетграла ](https://studwork.ru/spravochnik/matematika/vychislenie-dvoynyh-integralov)
* [Докуменатция по WPF C# ](https://metanit.com/sharp/wpf/)
* [Видео курс по WPF C#](https://www.youtube.com/playlist?list=PL0lO_mIqDDFVI0xwaYbm7h9ewYu5hftfA)
