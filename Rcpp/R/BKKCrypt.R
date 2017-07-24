#' BKKCrypt Encryption
#' @param x string
#' @return "encrypted" string
#' @export
#' @useDynLib BKKCrypt
#' @exportPattern ^[[:alpha:]]+
#' @importFrom checkmate assert_character
#' @importFrom Rcpp evalCpp
BKKCrypt <- function(x) {
    assert_character(x)
    rcpp_BKKCrypt(x)
}
