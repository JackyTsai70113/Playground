// MongoDB Playground
// Use Ctrl+Space inside a snippet or a string literal to trigger completions.

// mongosh --port 27017

// The current database to use.
use('shop');

// GET
// find({query}, {projection})
// db.students.find({ })
// db.students.find({}, { _id: false })

// sort, limit
// db.getCollection('students').find({}).sort({name:-1}).limit(1);
// db.getCollection('students').find({}).sort({ name: 1 }).limit(1);
// db.getCollection('students').find({ gpa: { $gte: 2 } }).sort({ gpa: -1 });

// comparison operators
// db.students.find({name: {$ne: "Spongebob"}})
// db.students.find({gpa: {$gte: 3,$lte: 4}})
// db.students.find({name: {$in:["Spongebob", "Patrick", "Sandy"]}})
// db.students.find({name: {$nin:["Spongebob", "Patrick", "Sandy"]}})
// db.students.find()
// logical operators: $and, $not, $nor, $no
// db.students.find({ $and: [{ fullTime: true }, { age: { $lte: 22 } }] });
// db.students.find({ $or: [{ fullTime: true }, { age: { $lte: 22 } }] })
// db.students.find({ $nor: [{ fullTime: true }, { age: { $lte: 22 } }] })
// db.students.find({ age: { $not: { $gte: 30 } } }) // return null

// UPDATE
// update => updateOne(filter, update)
// db.students.updateOne({ name: "Spongebob" }, { $set: {fullTime: true} })
// db.students.updateOne({ _id: ObjectId("66f7c885f206f2f5612449f4") }, { $set: { fullTime: false } })
// db.students.updateOne({ _id: ObjectId("66f7c885f206f2f5612449f4")}, { $unset: {fullTime: ""} })
// db.students.updateMany({}, { $set: { fullTime: false } });
// db.students.updateMany({ fullTime: {$exists: false} }, { $set: { fullTime: true } });

// DELETE
// db.students.deleteOne({name:"Larry"})
// db.students.deleteMany({ registerDate: {$exists: false} })

// INDEX: quick lookup but slows insert update delete
// db.students.find({name:"Spongebob"}).explain("executionStats") //docsExamined
// db.students.createIndex({ name: 1 })
// db.students.dropIndex("name_1")
// db.students.getIndexes()

// collections
// db.createCollection("teachers", { capped: true, size: 10000000, max: 100 }, { autoIndexId: false });
// db.createCollection("courses");
// db.courses.drop();

// aggregate
// db.books.insertMany([
//     { _id: 1, book_id: 1, num: 100, status: "normal" },
//     { _id: 2, book_id: 2, num: 200, status: "normal" },
//     { _id: 3, book_id: 3, num: 300, status: "sold" },
//     { _id: 4, book_id: 1, num: 200, status: "sold" },
//     { _id: 5, book_id: 2, num: 100, status: "sold" },
//     { _id: 6, book_id: 3, num: 500, status: "normal" },
//     { _id: 7, book_id: 4, num: 600, status: "normal" },
//     { _id: 8, book_id: 4, num: 300, status: "sold" },
// ]);
// group
// db.books.aggregate(
//     { $match: { status: "sold", } },
//     { $group: { _id: "$book_id", total: { $sum: "$num" } } },
//     { $sort: { total: -1 } }
// );
// addFields
// db.books.aggregate(
//     { $match: { status: "sold", } },
//     { $group: { _id: "$book_id", total: { $sum: "$num" } } },
//     { $addFields: { book_id: "$_id" } },
//     { $sort: { total: -1 } }
// );
// db.books.find({});
// lookup
// db.collection.aggregate([
//     {
//         $lookup: {
//             from: "",//<被join的目標表>,
//             localField: "", //<源表中的字段>,
//             foreignField: "", //<被join的目標表中的字段>,
//             as: "", //<返回滿足join條件下,被join的目標表中的文檔紀錄>
//         }
//     }
// ]);
// db.booksAttr.insertMany([
//     { _id: 1, type_id: 1, type_name: "science" },
//     { _id: 2, type_id: 2, type_name: "human" },
//     { _id: 3, type_id: 3, type_name: "music" },
//     { _id: 4, type_id: 4, type_name: "sports" },
// ]);
// db.getMongo().getDB("shop").books.aggregate([
//     { $match: { status: "sold" } },
//     { $group: { _id: "$book_id", total: { $sum: "$num" } } },
//     {
//         $lookup: {
//             from: "booksAttr",
//             localField: "_id",
//             foreignField: "type_id",
//             as: "booksAttr"
//         }
//     },
//     { $sort: { total: -1 } }
// ]);
// $project
// $out: 必須是最後一個步驟, 將結果輸出至 bookSold, 若集合不存在則創建一個, 若集合存在則覆蓋集合中的數據
db.getMongo().getDB("shop").books.aggregate([
    { $match: { status: "sold" } },
    { $group: { _id: "$book_id", total: { $sum: "$num" } } },
    {
        $lookup: {
            from: "booksAttr",
            localField: "_id",
            foreignField: "type_id",
            as: "booksAttr"
        }
    },
    { $project: { total: 1, "booksAttr.type_name": 1 } },
    { $sort: { total: -1 } },
    { $out: "bookSold" }
]);