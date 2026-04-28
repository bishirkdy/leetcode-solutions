class Calculator {
    constructor(value) {
        this.res = value
    }
    
    add(value){
        this.res += value
        return this
    }
    
    /** 
     * @param {number} value
     * @return {Calculator}
     */
    subtract(value){
        this.res -= value
        return this
    }
    
    /** 
     * @param {number} value
     * @return {Calculator}
     */  
    multiply(value) {
         this.res *= value
         return this
    }
    
    /** 
     * @param {number} value
     * @return {Calculator}
     */
    divide(value) {
        if(value === 0 || !value){
            throw new Error("Division by zero is not allowed")
        }
         this.res /= value
         return this
    }
    
    /** 
     * @param {number} value
     * @return {Calculator}
     */
    power(value) {
         this.res **= value
         return this
    }
    
    /** 
     * @return {number}
     */
    getResult() {
        return this.res
    }
}