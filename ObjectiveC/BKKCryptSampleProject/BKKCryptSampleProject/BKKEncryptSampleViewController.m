//
//  BKKEncryptSampleViewController.m
//  BKKCryptSampleProject
//
//  Created by Olah, Andras on 17/07/22.
//  Copyright © 2017 Moszinet. All rights reserved.
//

#import "BKKEncryptSampleViewController.h"
@import BKKCrypt;

@implementation BKKEncryptSampleViewController

- (IBAction)encrypt:(UIButton *)sender 
{
    [self.encrptedPasswordField setText:[BKKCrypt encryptPassword:self.passwordField.text]];
}



@end
