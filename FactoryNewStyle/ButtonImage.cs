using System.Windows;
using System.Windows.Controls;

namespace FactoryNewStyle
{

    public class ButtonImage : Button
    {
        #region Fields

        // Dependency property backing variables
        public static readonly DependencyProperty ImagePathProperty;
        public static readonly DependencyProperty TextProperty;

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        static ButtonImage()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ButtonImage), new FrameworkPropertyMetadata(typeof(ButtonImage)));

            // Initialize ImagePath dependency properties
            ImagePathProperty = DependencyProperty.Register("ImagePath", typeof(string), typeof(ButtonImage), new UIPropertyMetadata(null));
            TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(ButtonImage), new UIPropertyMetadata(null));
        }

        #endregion

        #region Dependency Property Wrappers

        /// <summary>
        /// The ImagePath dependency property.
        /// </summary>
        public string ImagePath
        {
            get { return (string)GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }

        /// <summary>
        /// The Text dependency property.
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        #endregion
    }
}
