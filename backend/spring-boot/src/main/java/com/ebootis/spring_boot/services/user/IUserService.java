package com.ebootis.spring_boot.services.user;

import com.ebootis.spring_boot.dtos.UserDTO;
import com.ebootis.spring_boot.models.User;
import com.ebootis.spring_boot.services.generic.ICombinedGenericService;

import java.util.List;

public interface IUserService extends ICombinedGenericService<User,UserDTO,Integer> {

}
