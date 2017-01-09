using System;
using System.Numerics;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Shapes;

namespace AiXiFan.Uwp.Controls
{
    [TemplatePart(Name = ShadowHostTemplateName, Type = typeof(UIElement))]
    [TemplatePart(Name = ContentPresenterTemplateName, Type = typeof(ContentPresenter))]
    public class Shadow : ContentControl
    {
        public static readonly DependencyProperty BlurRadiusProperty = DependencyProperty.Register(nameof(BlurRadius), typeof(double), typeof(Shadow), new PropertyMetadata(2d, BlurRadiusChanged));

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(nameof(Color), typeof(Color), typeof(Shadow), new PropertyMetadata(Colors.Black, ColorChanged));

        public static readonly DependencyProperty DepthProperty = DependencyProperty.Register(nameof(Depth), typeof(double), typeof(Shadow), new PropertyMetadata(2d, DepthChanged));

        public static readonly DependencyProperty DirectionProperty = DependencyProperty.Register(nameof(Direction), typeof(double), typeof(Shadow), new PropertyMetadata(270d, DirectionChanged));

        public static readonly DependencyProperty ShadowOpacityProperty = DependencyProperty.Register(nameof(ShadowOpacity), typeof(double), typeof(Shadow), new PropertyMetadata(1d, ShadowOpacityChanged));

        private const string ContentPresenterTemplateName = "PART_ContentPresenter";

        private const string ShadowHostTemplateName = "PART_ShadowHost";

        private readonly DropShadow _dropShadow;

        private readonly SpriteVisual _shadowVisual;

        private ContentPresenter _contentPresenter;

        public Shadow()
        {
            DefaultStyleKey = typeof(Shadow);

            var compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;
            _shadowVisual = compositor.CreateSpriteVisual();
            _dropShadow = compositor.CreateDropShadow();
            _shadowVisual.Shadow = _dropShadow;
        }

        public double BlurRadius
        {
            get
            {
                return (double)GetValue(BlurRadiusProperty);
            }
            set
            {
                SetValue(BlurRadiusProperty, value);
            }
        }

        public Color Color
        {
            get
            {
                return (Color)GetValue(ColorProperty);
            }
            set
            {
                SetValue(ColorProperty, value);
            }
        }

        public double Depth
        {
            get
            {
                return (double)GetValue(DepthProperty);
            }
            set
            {
                SetValue(DepthProperty, value);
            }
        }

        public double Direction
        {
            get
            {
                return (double)GetValue(DirectionProperty);
            }
            set
            {
                SetValue(DirectionProperty, value);
            }
        }

        public double ShadowOpacity
        {
            get
            {
                return (double)GetValue(ShadowOpacityProperty);
            }
            set
            {
                SetValue(ShadowOpacityProperty, value);
            }
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var shadowHost = (UIElement)GetTemplateChild(ShadowHostTemplateName);
            ElementCompositionPreview.SetElementChildVisual(shadowHost, _shadowVisual);

            _contentPresenter = (ContentPresenter)GetTemplateChild(ContentPresenterTemplateName);
            _contentPresenter.SizeChanged += (sender, e) =>
            {
                UpdateShadowMask();
                UpdateShadowSize();
            };
            UpdateShadowMask();
            UpdateShadowSize();
        }

        private static void BlurRadiusChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (Shadow)d;
            var value = (double)e.NewValue;
            obj._dropShadow.BlurRadius = (float)value;
        }

        private static void ColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (Shadow)d;
            var value = (Color)e.NewValue;
            obj._dropShadow.Color = value;
        }

        private static void DepthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (Shadow)d;
            obj.UpdateShadowOffset();
        }

        private static void DirectionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (Shadow)d;
            obj.UpdateShadowOffset();
        }

        private static void ShadowOpacityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var obj = (Shadow)d;
            var value = (double)e.NewValue;
            obj._dropShadow.Opacity = (float)value;
        }

        private void UpdateShadowMask()
        {
            var content = Content;
            var image = content as Image;
            if (image != null)
            {
                _dropShadow.Mask = image.GetAlphaMask();
            }
            else
            {
                var shape = content as Shape;
                if (shape != null)
                {
                    _dropShadow.Mask = shape.GetAlphaMask();
                }
                else
                {
                    var textBlock = content as TextBlock;
                    if (textBlock != null)
                    {
                        _dropShadow.Mask = textBlock.GetAlphaMask();
                    }
                }
            }
        }

        private void UpdateShadowOffset()
        {
            var radian = Math.PI / 180d * Direction;
            var offsetX = (float)(Math.Cos(radian) * Depth);
            var offsetY = 0 - (float)(Math.Sin(radian) * Depth);
            _dropShadow.Offset = new Vector3(offsetX, offsetY, 0);
        }

        private void UpdateShadowSize()
        {
            _shadowVisual.Size = new Vector2((float)_contentPresenter.ActualWidth, (float)_contentPresenter.ActualHeight);
        }
    }
}