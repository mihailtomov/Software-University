const config = {
    development: {
        PORT: 5000,
        DB_CONNECTION: 'mongodb://localhost:27017/ExpenseTracker',
        SALT_ROUNDS: 1,
        SECRET: 'backendexam',
        AUTH_COOKIE: 'AUTH',
    },
    production: {
        PORT: 80,
        DB_CONNECTION: 'production connection string',
        SALT_ROUNDS: 10,
        SECRET: 'backendexam',
        AUTH_COOKIE: 'AUTH',
    }
}

module.exports = config[process.env.NODE_ENV];