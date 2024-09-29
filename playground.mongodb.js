// MongoDB Playground
// Use Ctrl+Space inside a snippet or a string literal to trigger completions.

// mongosh --port 27017

// The current database to use.
// use('school');

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