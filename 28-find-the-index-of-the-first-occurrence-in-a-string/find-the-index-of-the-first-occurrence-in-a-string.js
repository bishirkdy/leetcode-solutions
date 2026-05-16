/**
 * @param {string} haystack
 * @param {string} needle
 * @return {number}
 */
var strStr = function(haystack, needle) {
   let heyLength = haystack.length;
   let nedLength = needle.length;
    if(needle.length === 0){
        return -1
    }
   let i = 0;
   while(i < heyLength){
    let firstIndex = 0
    let j = i
    while(j < heyLength && firstIndex < nedLength && haystack[j] === needle[firstIndex]){
        j++
        firstIndex++
    }
    if(firstIndex === nedLength){
        return i
    }
    i++

   }
   return -1
};