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

use('shop')

// db.customers.insertOne({
//     cust_id: 123,
//     name: "Jack",
//     address: "china, beijing",
//     mobile: "133000100087",
//     orders: [{
//         order_id: 1,
//         createTime: new Date("2019-07-13T18:50:00.000+00:00"),
//         products: [{
//             prod_name: "surface Pro64G",
//             prod_manafacture: "microsoft"
//         }, {
//             prod_name: "mini Apple",
//             prod_manafacture: "Apple"
//         }]
//     }, {
//         order_id: 2,
//         createTime: new Date("2019-07-12T13:30:00.000+00:00"),
//         products: [{
//             prod_name: "xbox",
//             prod_manafacture: "microsoft"
//         }, {
//             prod_name: "iphone",
//             prod_manafacture: "Apple"
//         }]
//     }]
// });

// db.customers.insertMany([{
//     cust_id: 123,
//     name: "Jordan",
//     order_id: 1,
//     paid_amount: 1000
// }, {
//     cust_id: 123,
//     name: "Jordan",
//     order_id: 2,
//     paid_amount: 2000
// }, {
//     cust_id: 125,
//     name: "Bruce",
//     order_id: 3,
//     paid_amount: 3000
// }, {
//     cust_id: 125,
//     name: "Bruce",
//     order_id: 4,
//     paid_amount: 5000
// }, {
//     cust_id: 125,
//     name: "Bruce",
//     order_id: 6
// }]);

// db.customers.find({
//     paid_amount: { $nin:[1000,2000,3000]}
// });

// db.profiles.insertMany([{
//     cust_id: 128,
//     comments: "high value and address in china,beijing"
// }, {
//     cust_id: 129,
//     comments: "middle value and address in china,beijing"
// }, {
//     cust_id: 130,
//     comments: "low value and address in china,shanghai"
// }, {
//     cust_id: 131,
//     comments: "high value and address in china,shanghai"
// }, {
//     cust_id: 132,
//     comments: "low value and address in china,wuhan"
// }]);

// search in documents
// 要搜尋需要創建文本索引
// db.profiles.createIndex({ comments: "text" });
// db.profiles.find({
//     $text: {
//         // 查詢的 string
//         $search: "high value"
//         // 可選參數，指定語言，默認與索引一致
//         // $language:,
//         // 可選，設置字母大小寫敏感，默認為 false
//         // $caseSensitive:,
//         // 可選，設置變音符號敏感，默認為 false
//         // $diacriticSensitive:
//     }
// });
// 返回 high 或 value 的文檔紀錄
// db.profiles.find({ $text: { $search: "high value" } });
// 返回 精確匹配 "high value"
// db.profiles.find({ $text: { $search: "\"high value\"" } });
// 為了量化不同文檔的匹配度，mongoDb 可以為匹配的文檔打分
// db.profiles.find({
//     $text: { $search: "high value" }
// }, {
//     score: { $meta: "textScore" }
// }).sort({ score: { $meta: "textScore" } });

// 正則表達式
// {<field>:($regex: /pattern/, $options: '<options>')}
// db.profiles.find({
//     comments: {
//         $regex: /^high/ // start with high
//     }
// });
// db.profiles.find({
//     comments: {
//         // 包含 a 或是 A, i 表示不區分大小寫
//         $regex: /a/, $options: 'i'
//     }
// });
// db.profiles.find({
//     comments: {
//         $regex: /n$/ // end with n
//     }
// })

// search nested documents
// db.customers.insertOne({
//     _id: 9,
//     cust_id: 123,
//     name: "Jordan",
//     orders: {
//         orderid: 7,
//         item: "Books",
//         count: 200
//     },
//     paid_amount: 1200
// });
// db.customers.find({
//     "orders.count": {
//         $gt: 10
//     }
// });

// search array
// db.DictGoodAttribute.insertOne({
//     AttributeValue: ["收腰型", "修身型", "直筒型", "寬鬆型", "其他"]
// });
// db.DictGoodAttribute.find({ AttributeValue: ["收腰型", "修身型", "直筒型", "寬鬆型", "其他"] });
// db.DictGoodAttribute.find({ AttributeValue: "其他" });
// 只要 array 中有符合的都會搜尋的到
// db.DictGoodAttribute.find({ "price": { $gt: 3 } });
// 匹配指定位置的元素值
// db.DictGoodAttribute.find({ "price.2": { $gt: 7 } });
// db.orders.insertOne({
//     _id: 1,
//     StatusInfo: [{
//         Status: 9,
//         desc: "已取消"
//     }, {
//         Status: 2,
//         desc: "已付款"
//     }]
// });
// 匹配索引並匹配巢狀
// db.orders.find({ "StatusInfo.0.Status": { $gt: 3 } });
// db.GoodsValue.insertMany([{
//     _id: 1,
//     prices: [{
//         low: 1,
//         middle: 11,
//         high:13
//     },{
//         low: 1,
//         middle: 8,
//         high:15
//     }]
// },{
//     _id: 2,
//     prices: [{
//         low: 3,
//         middle: 11,
//         high:15
//     },{
//         low: 5,
//         middle: 9,
//         high:16
//     }]
// },{
//     _id: 3,
//     prices: [{
//         low: 3,
//         middle: 11,
//         high:15
//     },{
//         low: 6,
//         middle: 9,
//         high:16
//     }]
// }])
// db.GoodsValue.find({ "prices.low": 3 }, {_id: 0, "prices.low":1})
// db.customers.find();
// 排序: sort, 跳躍: skip(O(N)), 限制筆數: limit
// db.customers.find().sort({ cust_id:1}).skip(4).limit(5);

// INSERT
// db.collection.insert(
//     <document or array of documents>,
//     {
//         writeConcern: <document>, // 寫關注，默認是 w:1
//         // 寫入多條文檔紀錄時，按 array 中的順序寫入
//         ordered: <boolean> 
//     }
// )
// db.customers.insertOne({
//     cust_id: 126,
//     name: "Lee",
//     orders: {
//         orderid: 10,
//         item: "phones",
//         count: 2
//     },
//     paid_amount: 3000
// });
// bulkWrite only supports insertOne, updateOne, updateMany, deleteOne, deleteMany. 可以只取得處理成功的文檔紀錄
db.customers.bulkWrite([{
    insertOne: {
        _id: 17,
        cust_id: 125,
        name: "Lee",
        orders_id: 2,
        paid_amount: 1000
    }
}, {
    insertOne: {
        _id: 18,
        cust_id: 123,
        name: "Jordan",
        orders_id: 2,
        paid_amount: 2000
    }
}]);