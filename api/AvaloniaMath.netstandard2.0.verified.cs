﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 7.0.8.6004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace AvaloniaMath.Controls
{
    public partial class FormulaBlock : Avalonia.Controls.Control
    {
        public static readonly Avalonia.StyledProperty<System.Collections.ObjectModel.ObservableCollection<System.Exception>> ErrorsProperty;
        public static readonly Avalonia.StyledProperty<Avalonia.Markup.Xaml.Templates.ControlTemplate> ErrorTemplateProperty;
        public static readonly Avalonia.StyledProperty<string> FormulaProperty;
        public static readonly Avalonia.StyledProperty<bool> HasErrorProperty;
        public static readonly Avalonia.StyledProperty<double> ScaleProperty;
        public static readonly Avalonia.StyledProperty<string> SystemTextFontNameProperty;
        public FormulaBlock() { }
        public System.Collections.ObjectModel.ObservableCollection<System.Exception> Errors { get { throw null; } }
        public Avalonia.Markup.Xaml.Templates.ControlTemplate ErrorTemplate { get { throw null; } set { } }
        public string Formula { get { throw null; } set { } }
        public bool HasError { get { throw null; } }
        public double Scale { get { throw null; } set { } }
        public string SystemTextFontName { get { throw null; } set { } }
        protected void InvalidateFormattedText() { }
        protected override Avalonia.Size MeasureOverride(Avalonia.Size availableSize) { throw null; }
        public override void Render(Avalonia.Media.DrawingContext context) { }
    }
}
namespace AvaloniaMath.Fonts
{
    public partial class AvaloniaMathFontProvider : XamlMath.Fonts.IFontProvider
    {
        internal AvaloniaMathFontProvider() { }
        public static AvaloniaMath.Fonts.AvaloniaMathFontProvider Instance;
        public XamlMath.Fonts.IFontTypeface ReadFontFile(string fontFileName) { throw null; }
    }
}
namespace AvaloniaMath.Parsers
{
    public static partial class AvaloniaTeXFormulaParser
    {
        public static XamlMath.TexFormulaParser Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
    }
}
namespace AvaloniaMath.Rendering
{
    public static partial class AvaloniaBrushExtensions
    {
        public static Avalonia.Media.IBrush? ToAvalonia(this XamlMath.Rendering.IBrush? brush) { throw null; }
        public static XamlMath.Rendering.IBrush? ToPlatform(this Avalonia.Media.Brush? brush) { throw null; }
    }
    public partial class AvaloniaBrushFactory : XamlMath.Rendering.IBrushFactory
    {
        internal AvaloniaBrushFactory() { }
        public static AvaloniaMath.Rendering.AvaloniaBrushFactory Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public XamlMath.Rendering.IBrush FromColor(XamlMath.Colors.RgbaColor color) { throw null; }
    }
    public static partial class AvaloniaTeXEnvironment
    {
        public static XamlMath.TexEnvironment Create(XamlMath.TexStyle style = 0, double scale = 20, string systemTextFontName = "Arial", Avalonia.Media.Brush? foreground = null, Avalonia.Media.Brush? background = null) { throw null; }
    }
}
