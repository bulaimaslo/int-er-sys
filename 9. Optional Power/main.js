function optionalPow(a, b) {
    let msg = "Perfom the calculation?";

    if (confirm(msg) == true) {
        return a ** b;
    } else {
        return b ** a;
    }
}
