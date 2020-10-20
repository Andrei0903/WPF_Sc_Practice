# WPF_Sc_Practice

## MaterialDesign installer

<hr>

> App.xaml

```sh

<Application.Resources> <br>
        <ResourceDictionary> <br>
            <ResourceDictionary.MergedDictionaries> <br>
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml" /> <br>
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml" /> <br>
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.DeepPurple.xaml" /> <br>
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml" /> <br>
            </ResourceDictionary.MergedDictionaries> <br>
        </ResourceDictionary> <br>
    </Application.Resources>


```

> add MainForm

```sh 

xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"

```
