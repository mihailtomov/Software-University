const express = require('express');
const handlebars = require('express-handlebars');
const cookieParser = require('cookie-parser');
const session = require('express-session');
const auth = require('../middlewares/auth');
const path = require('path');

module.exports = (app) => {
    app.engine('hbs', handlebars({
        extname: 'hbs',
        layoutsDir: path.join(__dirname, '../views/layouts'),
        defaultLayout: 'main',
        partialsDir: path.join(__dirname, '../views/partials'),
        // helpers: {
        //     isLoggedIn: function (loggedIn) {
        //         return loggedIn;
        //     }
        // }
    }));

    app.set('view engine', 'hbs');

    app.set('views', [
        path.join(__dirname, '../views/course pages'),
        path.join(__dirname, '../views/home pages'),
        path.join(__dirname, '../views/user pages'),
    ]);

    app.use(express.static('static'));

    app.use(express.urlencoded({ extended: true }));

    app.use(cookieParser());

    app.use(session({
        secret: 'test',
        resave: false,
        saveUninitialized: true,
        cookie: { secure: false }
      }));

    app.use(auth());
}