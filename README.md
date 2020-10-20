# WPF_Sc_Practice

## MaterialDesign installer

<hr>

> App.xaml

```sh

<Application.Resources> 
        <ResourceDictionary> 
            <ResourceDictionary.MergedDictionaries> 
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml" /> 
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml" /> 
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.DeepPurple.xaml" /> 
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml" /> 
            </ResourceDictionary.MergedDictionaries> 
        </ResourceDictionary> 
    </Application.Resources>


```

> add MainForm

```sh 

xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"

```
