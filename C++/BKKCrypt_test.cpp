#define CATCH_CONFIG_MAIN  // This tells Catch to provide a main() - only do this in one cpp file
#include "catch.hpp"
#include "BKKCrypt.hpp"

TEST_CASE( "BKKCrypt returns a super encrypted version for a string password.", "[bkkcrypt]" ) {
    REQUIRE( BKKCrypt::BKKCrypt("password") == "password" );
    // Rijndael-256:CBC = BASE64
    REQUIRE( BKKCrypt::BKKCrypt("password") != "7KVcbLRkKU15XiCRlTGuj0raudw+pl+SaGVnm456LoE=" );
}