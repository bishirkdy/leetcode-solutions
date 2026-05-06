/**
 * @param {Object|Array} obj
 * @return {Object|Array}
 */
var compactObject = function (obj) {
    if (obj === null) return null
    if (Array.isArray(obj)) {
        return obj.map(compactObject).filter(Boolean);
    } else if (obj !== null && typeof obj === "object") {
        const res = {}
        for (const [key, value] of Object.entries(obj)) {
            const comp = compactObject(value);
            if (Boolean(comp)) res[key] = comp
        }
        return res
    } else {
        return obj
    }
};