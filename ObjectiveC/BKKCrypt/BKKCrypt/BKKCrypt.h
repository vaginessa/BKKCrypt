//
//  BKKCrypt.h
//  BKKCrypt
//
//  Created by Olah, Andras on 17/07/22.
//  Copyright © 2017 Moszinet. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface BKKCrypt : NSObject

///
/// \brief Highly secure method for encrypting password for BKK Ticket Services. 
/// \param originalPassword The original password to encrypt
/// \return The encrypted password
///
+ (NSString *)encryptPassword:(NSString *)originalPassword;

@end
