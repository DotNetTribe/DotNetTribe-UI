const { addDynamicIconSelectors } = require('@iconify/tailwind');
/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ['./**/*.{razor,html,cshtml}'],
  theme: {
    extend: {
      colors: {
        'primary': '#F39237',
        'secondary': '#5227D3',
        'primary-bg': '#F5F5F5',
        'secondary-bg': '#FDF5E6',
        'dark': '#263238',
        'accent': '#D63230',
          },
          backgroundImage: {
              'blog-landingbg': "url('/assets/blogpagelanding.png')",
              'footer-texture': "url('/img/footer-texture.png')",
          },
      fontFamily: {
        'grotesk': ['Familjen Grotesk', 'sans-serif'],
        'sourceSans': [' "Source Sans 3" ', 'sans-serif'],
      },
      fontSize: {
        'xs': '.75rem',
        'sm': '.875rem',
        'tiny': '.875rem',
        'base': '1rem',
        'lg': '1.125rem',
        'xl': '1.25rem',
        '2xl': '1.5rem',
        '3xl': '1.875rem',
        '4xl': '2.25rem',
        '5xl': '3rem',
        '6xl': '4rem',
        '7xl': '5rem',
      },
      fontWeight: {
        'light': 300,
        'normal': 400,
        'medium': 500,
        'semibold': 600,
        'bold': 700,
        'extrabold': 800,
        'black': 900,
      },
    },
  },
  plugins: [
    // Iconify plugin
    addDynamicIconSelectors(),
  ],
}

