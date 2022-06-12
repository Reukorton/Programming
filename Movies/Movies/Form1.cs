using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Movies.Model;

namespace Movies
{
    public partial class Form1 : Form
    {
        private List<Movie> _movies;

        private Movie _currentMovie;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
