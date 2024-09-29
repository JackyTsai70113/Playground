/* global use, db */
// MongoDB Playground
// To disable this template go to Settings | MongoDB | Use Default Template For Playground.
// Make sure you are connected to enable completions and to be able to run a playground.
// Use Ctrl+Space inside a snippet or a string literal to trigger completions.
// The result of the last command run in a playground is shown on the results panel.
// By default the first 20 documents will be returned with a cursor.
// Use 'console.log()' to print to the debug output.
// For more documentation on playgrounds please refer to
// https://www.mongodb.com/docs/mongodb-vscode/playgrounds/

// Select the database to use.
use('shop');

db.customers.insertOne({
    cust_id: 123,
    name: "Jack",
    address: "china, beijing",
    mobile: "133000100087",
    orders: [{
        order_id: 1,
        createTime: new Date(2019, 7, 13),
        products: [{
            prod_name: "surface Pro64G",
            prod_manafacture: "microsoft"
        }, {
            prod_name: "mini Apple",
            prod_manafacture: "Apple"
        }]
    }, {
        order_id: 2,
        createTime: new Date(2019, 7, 12),
        products: [{
            prod_name: "xbox",
            prod_manafacture: "microsoft"
        }, {
            prod_name: "iphone",
            prod_manafacture: "Apple"
        }]
    }]
});

db.customers.find({ cust_id: 123 }, {name: 1, orders: 1});