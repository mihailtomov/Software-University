const mongoose = require('mongoose');

const userSchema = mongoose.Schema({
    email: {
        type: String,
        unique: true,
    },
    username: {
        type: String,
        unique: true,
    },
    password: {
        type: String,
    },
    bookedHotels: [{
        type: mongoose.Schema.Types.ObjectId,
        ref: 'Hotel',
    }],
    offeredHotels: [{
        type: mongoose.Schema.Types.ObjectId,
        ref: 'Hotel',
    }]
});

const User = mongoose.model('User', userSchema);

module.exports = User;