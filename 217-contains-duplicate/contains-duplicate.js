/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function (nums) {
    const res = {}
    for (let val of nums) {
        if (!res[val]) {
            res[val] = 1
        } else {
            return true
        }
    }
    return false
};