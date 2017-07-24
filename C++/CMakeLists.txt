cmake_minimum_required(VERSION 3.0)

project(bkkcrypt)

# Prepare "Catch" library for other executables
set(CATCH_INCLUDE_DIR ${CMAKE_CURRENT_SOURCE_DIR}/catch)
add_library(Catch INTERFACE)
target_include_directories(Catch INTERFACE ${CATCH_INCLUDE_DIR})

# Make test executable
set(TEST_SOURCES ${CMAKE_CURRENT_SOURCE_DIR}/BKKCrypt_test.cpp)
add_executable(tests ${TEST_SOURCES} BKKCrypt.cpp)
target_link_libraries(tests Catch)
add_custom_command(TARGET tests POST_BUILD COMMAND tests)