using playground.TwoPointers;
using playground.UnitTest.Utils;

namespace playground.UnitTest.TwoPointers;

public class NumSubseqTest
{
    [Theory]
    [InlineData("[3,5,6,7]", 9, 4)]
    [InlineData("[3,3,6,8]", 10, 6)]
    [InlineData("[2,3,3,4,6,7]", 12, 61)]
    [InlineData("[14,4,6,6,20,8,5,6,8,12,6,10,14,9,17,16,9,7,14,11,14,15,13,11,10,18,13,17,17,14,17,7,9,5,10,13,8,5,18,20,7,5,5,15,19,14]", 22, 272187084)]
    [InlineData("[14,4,6,6,20,8,5,6,8,12,6]", 22, 1020)]
    [InlineData("[9,25,9,28,24,12,17,8,28,7,21,25,10,2,16,19,12,13,15,28,14,12,24,9,6,7,2,15,19,13,30,30,23,19,11,3,17,2,14,20,22,30,12,1,11,2,2,20,20,27,15,9,10,4,12,30,13,5,2,11,29,5,3,13,22,5,16,19,7,19,11,16,11,25,29,21,29,3,2,9,20,15,9]", 32, 91931447)]
    [MemberData(nameof(Data))]
    public void NumSubseq(string nums, int target, int expected)
    {
        var actual = NumSubseqClass.NumSubseq(nums.ToArr<int>(), target);
        Assert.Equal(expected, actual);
    }

    public static IEnumerable<object[]> Data => new object[][]{
        new object[]{
            "[960,344,732,461,363,666,580,852,253,508,961,867,798,615,871,201,556,488,977,612,612,336,561,332,282,168,133,598,372,191,768,180,92,85,926,470,434,952,894,645,256,981,262,642,400,399,379,757,60,489,145,226,666,765,467,559,697,164,862,157,578,910,458,220,452,104,288,665,57,181,874,346,617,896,917,737,604,535,257,118,916,643,95,145,857,633,166,146,814,643,487,999,813,329,288,461,787,968,468,792,721,294,562,999,841,572,267,576,898,905,432,385,545,478,513,130,456,518,268,687,691,489,803,479,331,982,611,778,743,132,269,461,718,984,533,851,266,92,949,202,562,623,907,716,372,761,650,82,787,90,179,488,920,621,621,649,925,465,523,52,879,771,395,309,751,276,894,76,861,580,489,683,674,485,183,323,119,463,910,86,186,659,898,510,357,573,187,980,998,556,775,78,506,990,997,939,594,542,886,177,397,210,830,968,314,680,626,825,973,659,991,991,497,906,199,798,848,760,506,494,351,724,953,550,554,606,779,127,453,715,370,255,394,587,416,955,860,80,102,439,997,241,724,735,821,654,578,587,265,908,477,804,113,282,239,819,958,313,59,591,553,959,235,174,523,73,823,517,444,458,558,707,88,568,877,463,406,948,99,94,546,504,459,323,959,779,582,736,353,990,381,553,809,789,759,926,561,339,344,250,450,507,879,209,270,291,464,98,634,895,859,684,273,97,410,566,232,513,65,453,211,965,777,438,178,517,316,332,82,797,525,682,608,67,375,137,185,456,230,421,458,400,784,278,723,751,845,802,817,955,717,493,791,427,446,691,649,684,455,78,204,487,560,698,934,388,343,744,315,469,564,198,800,366,333,382,615,102,711,402,325,452,313,570,688,540,529,460,448,377,924,841,329,840,147,746,446,126,801,140,568,517,221,345,654,750,333,54,123,982,827,114,902,293,969,58,202,907,76,231,931,949,536,845,638,262,500,707,428,311,967,454,964,150,989,717,216,215,120,284,265,752,851,332,837,430,981,499,218,333,626,876,566,618,954,591,342,558,612,730,499,701,76,774,910,908,144,926,107,471,360,247,578,420,762,653,285,775,414,313,944,826,977,594,466,349,52,130,67,68,849,960,802,598,876,378,224,55,407,668,287,965,553,325,933,254,426,535,83,463,568,273,482,860,135,944,261,498,682,670,397,979,737,889,230,598,91,181,687,728,814,254,758,754,292,786,296,448,738,914,725,764,261,640,914,644,505,740,369,169,360,296,378,790,959,327,810,328,242,120,675,884,960,583,596,918,854,265,114,544,487,971,122,957,697,408,936,423,599,513,682,359,931,589,725,143,626,206,582,116,972,893,601,822,704,93,904,662,631,429,566,999,605,657,194,325,55,395,112,663,62,954,546,442,903,166,894,56,93,294,971,882,142,511,919,770,176,808,354,440,495,371,228,145,85,133,303,930,562,532,330,667,498,221,644,887,147,335,546,206,889,701,567,114,866,981,460,652,139,539,971,669,279,686,997,180,710,259,774,287,641,422,135,784,588,592,92,706,377,833,956,72,226,616,317,387,527,249,741,115,369,976,697,765,791,400,576,471,850,752,789,190,564,957,474,252,300,89,228,603,973,694,51,381,322,403,77,792,217,285,409,839,727,965,604,988,721,552,146,954,337,798,742,820,791,810,238,619,832,427,900,202,144,766,249,379,413,222,161,980,170,682,633,907,414,132,613,100,122,472,234,252,510,874,763,161,63,232,616,349,151,267,352,917,984,568,72,692,915,432,802,720,930,767,169,746,136,931,337,440,542,277,851,650,390,771,858,157,919,721,175,852,313,339,993,175,693,850,624,160,153,804,579,804,106,287,450,187,417,58,475,778,265,751,433,486,977,641,726,384,614,828,216,322,169,838,522,150,173,168,72,595,170,958,471,447,258,519,446,230,503,513,978,210,433,951,222,997,860,94,944,326,894,314,525,455,127,81,561,828,503,677,266,874,980,373,836,614,763,948,542,908,647,839,68,138,115,846,740,721,611,458,95,278,860,671,123,967,595,468,726,951,272,464,417,807,132,92,171,295,754,685,110,489,585,939,978,895,351,481,208,121,646,553,588,411,785,667,734,178,358,619,853,564,322,180,978,163,229,162,205,485,208,375,589,812,158,797,784,668,892,364,74,744,989,845,71,568,441,727,964,558,62,347,239,499,56,864,923,502,398,478,397,397,150,988,556,310,848,299,713,244,618,921,922,416,638,730,288,885,894,57,187,477,755,792,819,463,630,551,701,160,815,869,257,496,992,225,377,168,615,510,146,203,274,925,683,580,650,672,215,794,110,264,921,989,328,538,532,314,332,483,984,262,734,324,841,596,488,883,286,691,286,649,87,469,195,683,868,962,809,676,594,622,424,293,572,107,335,824,483,55,841,996,389,650,309,62,318,246,423,324,484,381,301,135,931,109,894,983,469,790,818,640,354,414,620,747,263,865,715,473,77,578,77,810,559,448,294,519,463,344,454,299,783,836,239,411,623,433,372,927,819,779,890,97,714,983,712,123,63,628,196,78,755,551,623,252,332,898,863,973,501,543,251,60,519,287,684,389,132,661,199,623,83,638,455,963,799,519,607,810,276,696,838,993,199,367,777,221,448,484,328,937,210,559,788,937,891,595,702,849,149,779,229,386,714,539,398,593,750,935,572,598,909,992,857,312,778,981,247,915,85,545,850,415,395,782,120,868,235,343,417,415,960,201,450,473,702,313,300,179,859,739,443,133,672,275,987,398,685,608,443,357,505,771,186,412,291,151,741,748,388,987,840,914,112,187,693,524,71,204,418,613,64,883,442,414,894,496,263,828,624,674,238,274,211,605,899,491,902,837,216,85,650,783,459,59,475,665,629,120,240,50,256,256,474,203,147,813,84,108,677,693,804,536,127,228,684,483,361,77,469,195,437,327,581,450,546,762,694,883,105,536,645,146,80,513,199,254,756,172,861,608,857,72,963,234,108,670,747,230,600,775,856,337,246,457,438,840,306,544,651,488,634,827,523,236,673,640,662,870,673,502,786,102,555,63,176,319,192,262,700,387,839,532,521,606,988,93,213,650,265,253,698,642,220,863,102,271,796,314,281,810,239,799,619,389,732,763,174,62,473,811,659,385,234,383,451,435,899,130,232,300,534,120,688,388,73,429,435,125,582,617,963,341,508,917,921,309,52,477,647,558,633,886,329,879,588,142,755,831,529,87,914,868,244,840,605,245,581,144,856,103,326,314,343,944,531,771,666,284,694,323,917,325,894,171,81,192,196,436,531,519,896,453,125,470,400,238,135,648,712,279,798,391,772,629,126,564,858,203,737,803,109,749,277,972,735,844,612,70,487,249,213,598,666,953,505,615,638,282,504,663,458,445,1000,198,463,211,193,321,669,860,621,751,938,701,393,291,592,267,934,364,180,228,850,242,886,318,408,699,936,774,552,98,839,609,926,550,648,909,976,234,118,885,612,969,352,614,953,138,401,792,862,837,989,328,96,447,575,204,447,815,436,286,952,730,148,919,719,538,989,356,740,922,863,579,862,186,244,965,958,274,65,705,507,650,420,547,180,868,194,615,974,658,880,174,830,828,491,715,309,91,431,455,965,713,301,147,287,462,877,437,329,572,140,831,278,112,467,90,595,465,201,478,492,485,563,667,396,531,899,559,973,738,634,906,440,161,953,683,302,317,370,431,708,846,90,113,198,191,788,711,175,968,621,636,492,635,907,715,301,248,680,274,547,386,720,101,623,851,934,178,296,276,245,822,686,806,396,865,988,397,371,949,521,217,645,295,61,627,198,234,984,109,747,820,686,850,994,420,134,323,744,675,853,900,74,228,610,340,530,384,732,183,523,982,612,834,123,941,790,146,831,823,56,508,893,294,483,412,176,158,631,501,64,508,788,846,960,214,880,964,100,251,644,790,828,957,826,751,512,102,83,773,656,247,984,413,394,124,221,424,724,975,146,242,635,360,519,775,740,317,836,691,894,826,141,607,330,95,965,218,306,900,993,749,1000,525,204,226,820,164,882,202,364,382,561,230,467,430,406,929,677,625,973,491,521,746,698,479,444,703,431,965,423,874,137,617,902,883,661,492,918,749,224,673,333,238,349,870,329,959,216,968,508,357,291,334,241,880,706,270,71,590,732,376,55,76,946,866,98,783,914,88,456,891,232,136,670,538,914,502,315,309,640,120,706,245,159,306,407,134,720,50,941,371,231,581,316,621,72,672,951,963,891,635,680,488,446,459,163,72,67,641,968,926,236,979,751,558,565,324,944,54,106,352,126,194,91,202,341,822,96,788,176,971,776,398,349,750,919,415,976,516,125,856,830,164,921,339,55,917,282,869,106,220,441,268,870,907,468,558,792,135,172,945,307,748,445,232,432,993,577,765,550,423,547,158,708,955,207,174,70,378,577,653,183,455,202,113,854,382,210,892,902,198,120,207,630,655,591,266,330,765,416,106,478,133,919,173,545,856,678,648,967,858,734,677,298,649,951,576,883,622,741,807,873,526,185,824,926,613,956,603,778,631,575,575,313,306,760,326,863,95,908,84,693,624,629,368,553,291,477,860,338,581,81,446,108,925,786,256,668,433,556,868,249,513,628,698,576,639,349,221,243,347,431,539,894,193,105,56,680,189,697,348,281,454,318,86,830,379,794,310,312,146,162,603,480,889,844,415,539,182,997,412,567,994,686,483,177,267,922,734,498,752,553,490,853,740,729,764,289,997,636,724,709,316,658,467,930,799,989,583,488,906,394,794,808,704,456,155,97,589,288,644,450,397,692,414,713,714,242,777,920,591,560,900,52,980,626,320,622,348,224,112,649,398,765,592,612,54,560,762,792,705,811,353,724,931,985,312,971,238,704,565,950,685,961,585,877,600,379,588,55,585,917,700,507,897,575,889,86,550,610,732,213,292,702,150,401,862,372,567,280,71,266,132,721,605,576,863,525,106,890,298,511,969,107,64,650,459,525,301,519,709,593,858,446,668,259,73,595,305,776,344,743,480,158,117,150,543,923,958,914,823,469,776,778,468,434,931,708,157,292,237,365,722,166,250,479,976,62,706,292,487,627,922,583,548,395,647,719,890,693,908,398,668,221,338,767,194,459,643,268,456,561,301,408,523,935,83,199,154,227,932,618,183,147,258,461,721,688,265,475,786,488,266,122,301,271,664,73,405,867,708,874,90,362,345,106,531,462,153,212,668,503,75,668,817,424,786,424,337,873,600,667,518,267,344,260,630,740,638,981,482,74,440,279,254,266,703,235,991,58,448,687,813,997,208,705,780,488,408,463,524,310,756,608,368,779,339,130,516,474,995,237,877,364,193,801,249,546,318,650,259,441,892,391,777,888,691,144,403,526,885,83,944,150,368,878,930,787,821,476,560,466,859,343,323,767,299,761,345,383,96,66,276,957,925,320,143,533,574,154,582,190,690,507,220,280,69,497,151,903,971,609,512,502,393,329,523,552,566,820,286,57,203,63,505,888,794,592,795,295,262,188,850,672,538,322,579,672,598,612,706,815,242,122,935,267,344,279,198,987,400,905,120,306,996,356,335,896,354,537,564,360,699,207,952,942,567,888,331,112,144,889,861,176,370,154,614,901,815,844,192,443,985,685,671,468,63,216,313,463,836,768,866,764,555,298,925,365,199,1000,775,263,819,195,336,626,899,538,504,757,177,467,331,129,786,941,527,511,171,421,920,71,470,932,61,762,717,521,503,831,151,432,273,280,566,500,141,500,787,892,468,479,175,751,665,468,896,352,452,312,219,176,986,704,649,655,658,672,156,71,189,344,416,915,880,729,395,615,325,906,989,428,755,963,921,767,418,177,426,666,761,811,865,603,491,210,310,749,510,414,195,933,597,122,375,63,698,98,513,723,160,223,227,913,142,628,539,767,225,975,107,702,633,375,611,272,813,226,116,867,809,73,269,663,80,565,61,394,822,340,834,513,68,456,996,696,595,989,356,900,849,924,485,714,513,104,904,510,758,163,642,169,782,528,835,956,541,829,486,584,94,723,153,785,472,690,498,468,906,706,350,330,672,631,958,819,106,390,775,469,924,444,757,106,662,728,698,563,408,899,633,461,872,82,842,303,324,320,468,494,850,823,751,119,888,820,914,481,375,841,309,306,391,983,697,797,65,614,264,629,532,689,94,758,230,312,958,52,289,533,941,825,615,907,86,138,697,367,364,756,277,583,121,231,362,784,761,180,582,383,269,494,541,902,771,890,794,987,336,852,334,848,413,875,535,84,784,518,517,659,782,544,852,64,881,532,110,448,428,795,754,362,738,504,744,432,655,419,236,200,316,942,954,861,920,394,284,70,539,370,281,398,281,97,725,590,851,665,739,143,670,150,895,803,53,436,335,65,583,935,441,206,429,591,567,92,703,406,965,419,79,74,496,308,370,712,55,684,799,269,827,438,96,942,744,970,56,184,890,277,592,376,304,569,658,758,847,107,293,213,279,894,733,453,253,350,193,188,450,314,70,988,738,851,632,580,483,362,104,357,376,826,350,695,276,401,567,353,86,653,488,648,868,151,846,664,266,835,807,958,507,404,512,832,711,550,358,210,747,660,420,53,659,505,324,882,403,864,270,807,942,754,636,981,874,176,384,325,735,468,498,451,278,120,316,532,824,996,492,889,606,355,999,503,949,287,507,384,415,448,909,819,839,272,910,105,692,701,429,591,993,460,270,325,326,846,236,645,742,60,559,891,69,233,260,444,819,682,780,510,299,235,443,388,995,215,951,334,315,785,776,649,451,909,916,526,875,912,962,141,707,633,92,117,952,749,588,454,667,202,881,205,554,652,853,668,257,878,179,332,419,445,672,475,278,953,634,799,352,434,800,208,965,990,841,81,829,864,303,920,219,930,117,833,686,653,287,781,938,52,351,483,734,387,904,859,415,417,714,915,885,212,767,154,927,196,83,134,357,555,974,357,482,635,187,967,273,467,180,73,194,310,683,777,671,147,529,581,543,73,831,517,342,964,131,213,452,114,193,1000,481,695,341,886,345,704,574,361,441,239,631,908,450,462,422,459,302,382,177,499,454,600,419,253,258,981,773,941,880,416,709,910,91,62,226,241,745,541,209,93,816,932,613,731,581,782,852,969,343,882,710,580,433,206,990,535,461,913,794,987,228,429,882,406,743,520,435,204,230,73,121,830,323,371,181,742,595,614,685,561,243,240,459,629,553,277,386,550,408,953,332,240,141,482,766,611,66,168,734,321,542,578,345,366,342,680,550,465,266,336,589,127,627,544,328,387,625,920,448,649,944,311,950,378,337,295,280,684,328,701,885,684,674,977,226,273,718,196,553,957,61,987,899,70,229,286,896,110,714,629,570,686,232,208,620,958,942,697,445,344,682,678,885,677,408,451,211,511,931,614,891,693,712,382,680,138,168,880,309,691,696,674,98,412,726,142,559,938,57,230,169,541,158,241,851,783,771,509,790,438,290,631,387,68,933,730,773,880,973,384,447,809,503,459,523,250,638,926,713,86,893,670,602,432,180,632,652,188,734,909,289,974,725,778,715,381,990,672,312,258,232,82,118,251,651,340,753,898,658,67,665,855,354,967,140,321,954,710,221,645,194,228,406,654,603,869,480,760,292,757,114,246,132,369,52,767,342,588,312,776,765,398,350,804,693,576,808,501,779,722,231,586,321,535,706,107,509,458,311,175,774,629,274,480,779,236,913,544,52,970,696,794,946,862,687,905,906,836,807,281,167,76,991,318,564,400,798,57,943,299,359,218,684,541,450,438,206,621,85,56,271,200,340,577,442,298,512,240,819,771,515,313,781,816,156,580,623,598,949,877,856,414,727,159,994,840,707,150,217,348,76,221,644,678,540,360,733,997,95,635,851,416,320,945,436,795,656,64,287,116,448,295,331,677,305,228,405,996,271,417,215,250,374,489,622,917,430,396,576,769,158,612,368,391,105,389,774,731,713,586,838,171,618,681,381,164,861,116,879,395,602,619,306,210,638,183,983,382,481,92,453,671,234,860,116,214,283,753,226,319,445,977,868,418,929,651,522,863,196,920,536,432,926,679,177,78,928,156,569,573,826,383,374,942,337,363,81,435,830,909,882,434,823,806,198,585,621,157,230,856,912,144,670,910,875,139,502,535,103,591,957,812,886,467,50,612,459,127,289,892,990,558,252,758,546,449,875,716,596,719,777,722,643,414,644,242,486,577,793,758,806,73,432,130,437,118,560,972,298,776,216,757,903,622,128,350,157,400,666,209,341,255,179,562,760,575,558,606,137,884,833,742,128,526,810,821,664,964,673,733,460,756,965,813,617,132,802,243,843,735,487,330,164,651,546,802,53,233,956,916,67,228,875,71,744,328,76,775,467,955,865,114,865,768,211,892,745,254,896,667,918,943,887,928,483,425,478,922,441,453,62,513,884,295,434,518,181,426,74,687,440,538,250,235,140,107,774,676,518,939,954,264,757,593,935,129,823,967,106,71,295,167,747,874,256,686,149,654,201,332,896,798,431,675,525,247,493,702,454,533,842,231,174,327,799,196,358,967,229,887,634,947,252,751,359,118,999,87,657,125,602,882,277,128,295,336,129,448,776,355,101,353,225,54,777,911,557,189,464,169,335,123,89,106,962,921,892,805,918,958,339,347,214,986,180,956,509,441,136,935,907,345,811,405,274,923,749,520,723,657,366,329,102,708,640,493,689,599,358,887,335,63,132,278,260,764,310,746,352,78,657,668,143,960,201,574,696,553,164,643,537,667,148,240,556,341,477,871,201,839,709,344,957,322,450,222,767,544,64,695,563,441,236,773,937,287,244,538,226,114,403,1000,751,984,768,194,708,540,673,190,898,341,887,499,374,966,604,232,296,946,283,198,106,128,219,739,832,434,198,590,830,503,825,828,92,683,199,716,626,476,903,685,896,227,206,335,935,281,471,783,397,974,295,866,532,538,188,94,640,838,213,671,483,477,737,626,877,420,95,981,659,306,666,52,142,53,525,539,390,92,790,640,165,199,392,285,455,819,665,439,697,796,880,455,637,963,986,537,318,894,131,276,419,984,342,897,682,353,743,254,479,795,196,466,267,803,870,345,149,736,790,77,181,902,333,582,312,569,795,923,558,770,258,266,859,698,379,62,402,511,502,477,857,309,713,204,126,332,712,59,639,568,356,907,898,837,997,194,290,113,531,616,162,956,930,514,301,557,774,703,809,426,984,402,500,585,806,470,798,116,227,495,519,634,613,368,297,176,897,261,733,289,901,731,677,858,707,410,344,141,865,160,219,923,659,953,886,883,344,324,118,128,292,97,697,453,357,320,373,268,775,508,752,831,66,521,468,258,900,148,507,745,173,597,151,931,312,689,105,806,633,637,939,232,528,281,984,472,438,971,635,387,467,896,386,684,446,560,182,822,964,243,658,463,900,162,170,554,349,544,685,56,70,401,622,243,726,565,610,350,166,520,142,645,250,927,561,495,187,113,212,199,104,519,346,345,899,827,362,685,648,63,261,738,884,904,498,441,885,839,615,277,785,589,712,691,930,806,143,490,532,837,947,440,148,250,590,772,439,351,218,545,285,433,155,74,776,298,528,904,353,570,205,458,929,795,283,232,853,365,756,557,819,303,600,904,699,277,835,795,667,553,235,910,157,671,615,671,359,129,162,432,595,527,253,90,138,787,832,891,177,762,968,678,256,177,482,730,346,64,797,993,821,277,359,891,797,182,558,947,781,694,494,183,101,538,418,418,270,474,383,507,186,145,676,573,208,971,803,363,672,429,734,74,755,484,219,211,233,726,541,168,634,827,362,889,357,334,468,950,83,445,597,890,571,562,328,654,824,182,137,99,230,267,817,72,637,721,949,852,774,678,380,308,861,891,341,457,553,574,428,129,550,941,794,145,189,55,891,987,744,472,155,531,795,467,786,242,70,923,218,122,674,923,383,127,256,893,155,789,673,473,472,87,518,526,406,382,548,388,317,992,854,926,799,872,464,929,703,636,110,604,638,531,97,140,925,112,181,173,97,857,388,160,656,151,784,266,964,96,227,875,614,521,556,660,779,64,284,778,334,770,127,853,752,205,641,673,189,477,703,116,337,241,656,323,394,566,886,527,550,375,778,602,116,653,363,171,584,338,682,854,689,649,632,559,913,336,74,210,455,466,474,91,396,576,699,169,368,260,301,341,788,491,493,475,128,993,990,432,179,906,825,687,878,985,788,831,693,580,919,77,996,587,995,919,176,64,420,542,904,456,520,617,230,626,312,196,824,946,101,143,941,760,697,938,308,670,791,394,352,459,672,260,186,233,471,287,904,459,416,346,194,454,627,84,931,354,652,729,205,811,555,595,427,428,472,371,965,620,592,619,868,556,748,513,239,522,136,256,479,992,243,932,539,127,739,606,139,587,464,200,636,983,793,211,552,777,311,864,447,111,340,502,727,968,333,642,910,441,423,54,924,666,240,883,801,938,658,77,743,415,132,542,433,974,246,908,414,304,970,928,778,419,566,623,455,548,535,762,970,467,266,844,51,169,108,959,929,686,915,112,476,260,775,146,997,417,278,922,542,934,911,66,353,778,940,903,865,289,430,278,231,677,242,374,365,204,674,503,342,772,153,941,892,681,70,373,95,379,651,489,292,748,607,113,238,563,931,227,640,742,341,192,147,557,231,235,336,866,649,752,851,935,721,387,587,551,801,954,505,570,755,430,77,721,56,121,951,305,760,664,744,130,241,573,986,998,256,751,92,537,604,221,583,531,505,318,545,418,872,590,328,188,539,755,956,952,776,507,400,435,173,440,577,577,473,589,739,983,454,308,229,561,380,276,857,989,683,625,576,102,345,195,118,707,603,398,912,662,277,401,870,790,269]",
            587,
            28294894
        }
    };
}